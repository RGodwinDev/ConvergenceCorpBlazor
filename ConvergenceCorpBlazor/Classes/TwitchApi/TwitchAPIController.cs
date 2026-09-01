using ConvergenceCorpBlazor.Classes.TwitchApi.Streamers;
using ConvergenceCorpBlazor.Classes.TwitchApi.TwitchAPIResponseObjects;
using Newtonsoft.Json;

namespace ConvergenceCorpBlazor.Classes.TwitchApi;

public static class TwitchAPIController
{
    private static readonly string? client_id = Environment.GetEnvironmentVariable("TwitchClientID");
    private static readonly string? client_secret = Environment.GetEnvironmentVariable("TwitchClientSecret");
    private static TwitchClientCredential? ClientCredential;

    //basic http client for accessing twitch api
    private static readonly HttpClient TTVHttpClient = new HttpClient()
    {
        BaseAddress = new Uri("https://api.twitch.tv/helix/")
    };

    //add client_id and secret to the client
    public static async Task<bool> setupHttpClient()
    {
        if (client_id != null)
        {
            TTVHttpClient.DefaultRequestHeaders.Add("Client-Id", client_id);
            //TTVHttpClient.DefaultRequestHeaders.Add("client_secret", client_secret);
            return true;
        }
        else
        {
            Console.WriteLine("Twitch Client ID is NULL");
            return false;
        }
    }

    //get an access token for accessing the API
    public static async Task<bool> AcquireToken()
    {
        HttpClient tokenclient = new HttpClient()
        {
            BaseAddress = new Uri("https://id.twitch.tv/oauth2/token")
        };
        var parameters = new Dictionary<string, string>
        {
            {"client_id", client_id },
            {"client_secret", client_secret },
            {"grant_type", "client_credentials" }
        };
        var content = new FormUrlEncodedContent(parameters);
        using HttpResponseMessage response = await tokenclient.PostAsync("", content);
        response.EnsureSuccessStatusCode();
        
        Stream? stream = await response.Content.ReadAsStreamAsync();
        using (var streamReader = new StreamReader(stream))
        {
            using (var jsonTextReader = new JsonTextReader(streamReader))
            {
                var jsonSerializer = new JsonSerializer();
                ClientCredential = jsonSerializer.Deserialize<TwitchClientCredential>(jsonTextReader);
                
                //I wanted to use ClientCredential.token_type, BUT its all lower case
                //The token type being full lowercase when we retrieve it is cursed when it requires normal case in calls.
                TTVHttpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + ClientCredential.access_token);
                return true;
            }
        }
        return false;
    }

    /*
     * Called when the server is started
     * Gets all the info for the streamers from twitch.
     */
    public static async Task GetUsers()
    {
        string message = "users?";
        foreach(string name in Streamer.GetStreamerNames())
        {
            message += "&login=" + name;
        }
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, message);
        HttpResponseMessage response = await TTVHttpClient.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {                
            
            UserInfoFromAPI? value = await response.Content.ReadFromJsonAsync<UserInfoFromAPI>();
            if (value != null)
            {
                Streamer.SetALLStreamers(value.Data);
            }
        }
    }

    

    /*
     * Updates the live status and info about each streamer.
     */
    public static async void RefreshStreams(object? state)
    {
        string message = "streams?";
        foreach(Streamer s in Streamer.GetALLStreamers())
        {
            message += "&user_login=" + s.login;
        }

        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, message);
        try
        {
            HttpResponseMessage response = await TTVHttpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {

                StreamInfoFromAPI? value = await response.Content.ReadFromJsonAsync<StreamInfoFromAPI>();
                if (value != null)
                {
                    List<Streams> StreamList = value.Data.ToList();

                    //go through each streamer
                    foreach (Streamer streamer in Streamer.GetALLStreamers())
                    {
                        //check if theyre currently streaming
                        Streams? stream = StreamList.Find(s => s.user_id == streamer.id);
                        if (stream != null)
                        {
                            //if they are, update stream stuff and set them as live.
                            streamer.game_id = stream.game_id;
                            streamer.game_name = stream.game_name;
                            streamer.title = stream.title;
                            streamer.viewer_count = stream.viewer_count;

                            streamer.thumbnail_url = stream.thumbnail_url;
                            streamer.tag_ids = stream.tag_ids;
                            streamer.tags = stream.tags;
                            streamer.is_mature = stream.is_mature;
                            streamer.IsLive = true;
                            streamer.LastLive = DateTimeOffset.UtcNow;

                            streamer.started_at = stream.started_at;

                        }
                        else
                        {
                            //mark the streamer as not live!
                            streamer.IsLive = false;
                        }
                    }
                }
            }
            else
            {
                //unsuccessful API call
                Console.WriteLine(response.StatusCode);
                string result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
        }
        catch(Exception ex) {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }

    /*
     * Get the color of each streamer
     */
    public static async void GetUserColors()
    {
        string message = "chat/color?";
        foreach(Streamer streamer in Streamer.GetALLStreamers())
        {
            message += "&user_id=" + streamer.id;
        }
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, message);
        HttpResponseMessage response = await TTVHttpClient.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            UserColorFromAPI? value = await response.Content.ReadFromJsonAsync<UserColorFromAPI>();
            if(value != null)
            {
                List<UserColors> UserColorList = value.Data.ToList();
                foreach (UserColors color in UserColorList)
                {
                    Streamer? s = Streamer.GetStreamer(color.user_id);
                    if (s != null)
                    {
                        s.color = color.color;
                    }
                }
            }
        }
        else
        {
            //unsuccessful API call
            Console.WriteLine(response.StatusCode);
            string result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
        }
    }
}

using ConvergenceCorpBlazor.Classes.TwitchApi.Streamers;
using ConvergenceCorpBlazor.Classes.TwitchApi.TwitchAPIResponseObjects;

namespace ConvergenceCorpBlazor.Classes.TwitchApi;

/*
 * Most API calls to twitch come back in json form, with a Data array of the objects
 */

public class TwitchAPIResponses
{
}

/*
 * Get Users
 * GET https://api.twitch.tv/helix/users
 */
public class UserInfoFromAPI
{
    public Streamer[] Data { get; set; } = [];
}

/*
 * Get Streams
 * GET https://api.twitch.tv/helix/streams
 * returns only streams that are currently live
 */
public class StreamInfoFromAPI
{
    public Streams[] Data { get; set; } = [];
}

/*
 * Get User Chat Color
 * GET https://api.twitch.tv/helix/chat/color
 */
class UserColorFromAPI()
{
    public UserColors[] Data { get; set; } = [];
}
//using ConvergenceCorpBlazor.Classes.Guildwars2API.Objects;
using ConvergenceCorpBlazor.Classes.Guildwars2API.Objects;


namespace ConvergenceCorpBlazor.Classes.Guildwars2API;
public class GW2APIController
{
    private static readonly HttpClient GW2HttpClient = new HttpClient()
    {
        BaseAddress = new Uri("https://api.guildwars2.com/v2/")
    };

    public static async Task GetAllTitles()
    {
        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "titles?ids=all");
        HttpResponseMessage response = await GW2HttpClient.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            Title[]? value = await response.Content.ReadFromJsonAsync<Title[]>();
            if (value != null)
            {
                //save the title list
                for (int i = 0; i < value.Length; i++)
                {
                    Title.AddTitle(value[i]);
                }
            }
        }
    }


}

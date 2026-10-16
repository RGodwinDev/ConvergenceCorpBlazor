namespace ConvergenceCorpBlazor.Classes.Guildwars2API.Objects;
public class Title
{
    public int id { get; set; } = 0;
    public string name { get; set; } = "Default Title Name";
    public int? achievement { get; set; } = 0; //deprecated, use achievements.
    public int[]? achievements { get; set; } = []; //resolve against v2/achievemnts.
    public int? ap_required { get; set; } = 0; //optional, amount of achievement points required

    public static void AddTitle(Title t)
    {
        Titles[t.id] = t;
    }

    public static Dictionary<int, Title> Titles = new Dictionary<int, Title>();
}

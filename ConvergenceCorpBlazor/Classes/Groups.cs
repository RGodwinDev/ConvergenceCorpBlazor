public static class Groups
{
    private static List<Group> GroupList = [];

    /*
    *   Initializes the GroupList
    */
    public static void Startgroup()
    {   //31 is all Soto, 448 is all JW
        Group darens = new("logo", "Darens", "", ["https://twitch.tv/darenswiths"]);
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 6, 9, 15, 00, 00, DateTimeKind.Utc), 31));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 6, 10, 15, 00, 00, DateTimeKind.Utc), 448));

        Group ConvergenceCorp = new("/favicon/favicon-32x32.png", "Convergence Corp", "CC", ["https://convergencecorp.net"]);
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 6, 14, 18, 00, 00, DateTimeKind.Utc), 31));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 6, 10, 01, 00, 00, DateTimeKind.Utc), 448));

        Group ownly = new Group("logo", "Ownly", "FUN", []);
        ownly.AddRun(new GroupRun("NA", new DateTime()));

        Group Hella = new Group("logo", "Hella", "UHHH", []);
        Hella.AddRun(new GroupRun("NA", new DateTime(2025, 6, 12, 02, 00, 00, DateTimeKind.Utc)));

        Group SaS = new Group("logo", "Silverwastes Anonymous", "SAS", []);
        SaS.AddRun(new GroupRun("NA", new DateTime(2025, 6, 12, 20, 00, 00, DateTimeKind.Utc)));

        Group Sleepy = new Group("logo", "The Sleepiest Warriors", "SLPY", ["https://twitch.tv/projektdyad", "https://projektdyad.com"]);
        Sleepy.AddRun(new GroupRun("NA", new DateTime(2025, 6, 14, 01, 00, 00, DateTimeKind.Utc)));

        Group Lily = new Group("logo", "Cabaret Velour", "LILY", ["https://twitch.tv/lilyvelour"]);
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 6, 14, 21, 00, 00, DateTimeKind.Utc)));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 6, 10, 21, 00, 00, DateTimeKind.Utc)));

        Group Star = new Group("logo", "The Astral Light of Tyria", "STAR", []);
        Star.AddRun(new GroupRun("NA", new DateTime(2025, 6, 8, 22, 00, 00, DateTimeKind.Utc)));

        Group Godlyarms = new Group("logo", "Godlyarms", "GDAM", []);
        Godlyarms.AddRun(new GroupRun("NA", new DateTime(2025, 6, 7, 13, 00, 00, DateTimeKind.Utc)));

        Group WFSleep = new Group("logo", "We Fight Sleep", "COFE", ["https://www.twitch.tv/softbreadx"]);
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 6, 11, 05, 00, 00, DateTimeKind.Utc)));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 6, 12, 05, 00, 00, DateTimeKind.Utc)));

        Group SkeinGang = new Group("logo", "Skein Gang", "SG", ["https://discord.com/invite/skeingang"]);
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 6, 9, 1, 00, 00, DateTimeKind.Utc)));
        SkeinGang.AddRun(new GroupRun("EU", new DateTime(2025, 6, 14, 18, 30, 00, DateTimeKind.Utc)));

        Group VoidLounge = new Group("logo", "Void Lounge", "VL", []);
        Group MookChivalry = new Group("logo", "Mook Chivalry", "", ["https://twitch.tv/mookchivalry"]);
        MookChivalry.AddRun(new GroupRun("EU", new DateTime(2025, 6, 9, 13, 00, 00, DateTimeKind.Utc)));

        Group CUTE = new Group("logo", "Cruel Unending Tyrannic Entity", "CUTE", []);
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 6, 11, 18, 00, 00, DateTimeKind.Utc), 448));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 6, 12, 18, 00, 00, DateTimeKind.Utc), 31));

        Group LegendaryImpact = new Group("logo", "Legendary Impact", "PACT", []);
        LegendaryImpact.AddRun(new GroupRun("EU", new DateTime(2025, 6, 13, 18, 00, 00, DateTimeKind.Utc)));

        Group ODN = new Group("logo", "Orden der Nebel", "ODN", []);
        Group AllAboutCats = new Group("logo", "All About Cats", "", []);
    }
    public static List<Group> getList()
    {
        return GroupList;
    }

    public static List<Tuple<GroupRun, Group>> GetALLRegionRuns(string r)
    {
        List<Tuple<GroupRun, Group>> result = [];
        foreach (Group g in GroupList)
        {
            foreach (GroupRun gr in g.GetRegionRuns(r))
            {
                result.Add(new Tuple<GroupRun, Group>(gr, g));
            }
        }
        result.Sort((Tuple<GroupRun, Group> a, Tuple<GroupRun, Group> b) =>
        {
            return a.Item1.GetTime() < b.Item1.GetTime() ? -1 : 1;
        });
        return result;
    }
}
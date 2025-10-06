public static class Groups
{
    private static List<Group> GroupList = [];

    /*
    *   Initializes the GroupList
    */
    public static void Startgroup()
    {   //31 is all Soto, 448 is all JW
        Group darens = new("logo", "Darens", "",
        [
            new Tuple<string,string>("twitch","https://twitch.tv/darenswiths")
        ]);
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 9, 29, 15, 00, 00, DateTimeKind.Utc), 31));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 9, 30, 15, 00, 00, DateTimeKind.Utc), 448));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 10, 06, 15, 00, 00, DateTimeKind.Utc), 31));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 10, 07, 15, 00, 00, DateTimeKind.Utc), 448));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 10, 13, 15, 00, 00, DateTimeKind.Utc), 31));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 10, 14, 15, 00, 00, DateTimeKind.Utc), 448));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 10, 20, 15, 00, 00, DateTimeKind.Utc), 31));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 10, 21, 15, 00, 00, DateTimeKind.Utc), 448));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 10, 27, 15, 00, 00, DateTimeKind.Utc), 31));
        darens.AddRun(new GroupRun("NA", new DateTime(2025, 10, 28, 15, 00, 00, DateTimeKind.Utc), 448));

        Group ConvergenceCorp = new("/favicon/favicon-32x32.png", "Convergence Corp", "CC",
        [
            new Tuple<string, string>("discord","https://discord.gg/HyVZqAuAQ2"),
            new Tuple<string, string>("website", "https://convergencecorp.net")
        ]);

        //NA Saturdays
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 9, 27, 18, 00, 00, DateTimeKind.Utc), 31));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 10, 4, 18, 00, 00, DateTimeKind.Utc), 448));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 10, 11, 18, 00, 00, DateTimeKind.Utc), 31));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 10, 18, 18, 00, 00, DateTimeKind.Utc), 448));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 10, 25, 18, 00, 00, DateTimeKind.Utc), 31));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 11, 01, 18, 00, 00, DateTimeKind.Utc), 448));

        //NA Mondays
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 9, 30, 01, 00, 00, DateTimeKind.Utc), 31));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 10, 7, 01, 00, 00, DateTimeKind.Utc), 448));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 10, 14, 01, 00, 00, DateTimeKind.Utc), 31));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 10, 21, 01, 00, 00, DateTimeKind.Utc), 448));
        ConvergenceCorp.AddRun(new GroupRun("NA", new DateTime(2025, 10, 28, 01, 00, 00, DateTimeKind.Utc), 31));
        

        Group ownly = new Group("logo", "Ownly", "FUN", [
            new Tuple<string, string>("discord", "https://discord.gg/vQ5asNhZYB")
        ]);
        ownly.AddRun(new GroupRun("NA", new DateTime(2025, 9, 29, 21, 30, 00, DateTimeKind.Utc)));
        ownly.AddRun(new GroupRun("NA", new DateTime(2025, 10, 06, 21, 30, 00, DateTimeKind.Utc)));
        ownly.AddRun(new GroupRun("NA", new DateTime(2025, 10, 13, 21, 30, 00, DateTimeKind.Utc)));
        ownly.AddRun(new GroupRun("NA", new DateTime(2025, 10, 20, 21, 30, 00, DateTimeKind.Utc)));
        ownly.AddRun(new GroupRun("NA", new DateTime(2025, 10, 27, 21, 30, 00, DateTimeKind.Utc)));

        Group Hella = new Group("logo", "Hella", "UHHH", []);
        //NA Wednesday night
        Hella.AddRun(new GroupRun("NA", new DateTime(2025, 10, 02, 02, 00, 00, DateTimeKind.Utc)));
        Hella.AddRun(new GroupRun("NA", new DateTime(2025, 10, 09, 02, 00, 00, DateTimeKind.Utc)));
        Hella.AddRun(new GroupRun("NA", new DateTime(2025, 10, 18, 02, 00, 00, DateTimeKind.Utc)));
        Hella.AddRun(new GroupRun("NA", new DateTime(2025, 10, 25, 02, 00, 00, DateTimeKind.Utc)));
        Hella.AddRun(new GroupRun("NA", new DateTime(2025, 11, 01, 02, 00, 00, DateTimeKind.Utc)));

        Group SaS = new Group("logo", "Silverwastes Anonymous", "SAS", []);
        SaS.AddRun(new GroupRun("NA", new DateTime(2025, 10, 02, 20, 00, 00, DateTimeKind.Utc)));
        SaS.AddRun(new GroupRun("NA", new DateTime(2025, 10, 09, 20, 00, 00, DateTimeKind.Utc)));
        SaS.AddRun(new GroupRun("NA", new DateTime(2025, 10, 16, 20, 00, 00, DateTimeKind.Utc)));
        SaS.AddRun(new GroupRun("NA", new DateTime(2025, 10, 23, 20, 00, 00, DateTimeKind.Utc)));
        SaS.AddRun(new GroupRun("NA", new DateTime(2025, 10, 30, 20, 00, 00, DateTimeKind.Utc)));

        Group Sleepy = new Group("logo", "The Sleepiest Warriors", "SLPY", [
            new Tuple<string,string>("twitch", "https://twitch.tv/projektdyad"),
            new Tuple<string,string>("website","https://projektdyad.com")
        ]);
        //NA Friday SotO
        Sleepy.AddRun(new GroupRun("NA", new DateTime(2025, 9, 27, 01, 00, 00, DateTimeKind.Utc)));
        Sleepy.AddRun(new GroupRun("NA", new DateTime(2025, 10, 04, 01, 00, 00, DateTimeKind.Utc)));
        Sleepy.AddRun(new GroupRun("NA", new DateTime(2025, 10, 11, 01, 00, 00, DateTimeKind.Utc)));
        Sleepy.AddRun(new GroupRun("NA", new DateTime(2025, 10, 18, 01, 00, 00, DateTimeKind.Utc)));
        Sleepy.AddRun(new GroupRun("NA", new DateTime(2025, 10, 25, 01, 00, 00, DateTimeKind.Utc)));
        Sleepy.AddRun(new GroupRun("NA", new DateTime(2025, 11, 01, 01, 00, 00, DateTimeKind.Utc)));

        Group Lily = new Group("logo", "Cabaret Velour", "LILY",
        [
            new Tuple<string,string>("discord", "https://discord.gg/lilyvelour"),
            new Tuple<string,string>("twitch","https://twitch.tv/lilyvelour")
        ]);

        //NA Saturdays
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 9, 27, 21, 00, 00, DateTimeKind.Utc), 448));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 10, 04, 21, 00, 00, DateTimeKind.Utc), 31));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 10, 11, 21, 00, 00, DateTimeKind.Utc), 448));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 10, 18, 21, 00, 00, DateTimeKind.Utc), 31));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 10, 25, 21, 00, 00, DateTimeKind.Utc), 448));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 11, 01, 21, 00, 00, DateTimeKind.Utc), 31));

        //NA Tuesdays
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 9, 30, 21, 00, 00, DateTimeKind.Utc), 448));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 10, 07, 21, 00, 00, DateTimeKind.Utc), 31));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 10, 14, 21, 00, 00, DateTimeKind.Utc), 448));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 10, 21, 21, 00, 00, DateTimeKind.Utc), 31));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 10, 28, 21, 00, 00, DateTimeKind.Utc), 448));
        Lily.AddRun(new GroupRun("NA", new DateTime(2025, 11, 04, 21, 00, 00, DateTimeKind.Utc), 31));

        Group Star = new Group("logo", "The Astral Sanctuary", "STAR", [
            new Tuple<string,string>("discord","https://discord.gg/Kcf62kejz6")
        ]);

        //NA SotO Sundays
        Star.AddRun(new GroupRun("NA", new DateTime(2025, 9, 28, 22, 00, 00, DateTimeKind.Utc), 31));
        Star.AddRun(new GroupRun("NA", new DateTime(2025, 10, 5, 22, 00, 00, DateTimeKind.Utc), 31));
        //star on hiatus until after halloween events

        Group Godlyarms = new Group("logo", "Godlyarms", "GDAM", []);
        Godlyarms.AddRun(new GroupRun("NA", new DateTime(2025, 9, 24, 12, 00, 00, DateTimeKind.Utc), 31));
        Godlyarms.AddRun(new GroupRun("NA", new DateTime(2025, 9, 25, 13, 30, 00, DateTimeKind.Utc), 448));
        Godlyarms.AddRun(new GroupRun("NA", new DateTime(2025, 10, 02, 13, 30, 00, DateTimeKind.Utc), 448));
        Godlyarms.AddRun(new GroupRun("NA", new DateTime(2025, 10, 03, 14, 00, 00, DateTimeKind.Utc), 31));
        Godlyarms.AddRun(new GroupRun("NA", new DateTime(2025, 10, 08, 12, 00, 00, DateTimeKind.Utc), 31));
        Godlyarms.AddRun(new GroupRun("NA", new DateTime(2025, 10, 09, 13, 30, 00, DateTimeKind.Utc), 448));

        Group WFSleep = new Group("logo", "We Fight Sleep", "COFE", [
            new Tuple<string,string>("discord", "https://discord.gg/tS8D48HFAJ"),
            new Tuple<string,string>("twitch","https://www.twitch.tv/softbreadx")
        ]);
        //NA Tuesday/Wednesday night SotO
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 01, 05, 00, 00, DateTimeKind.Utc), 31));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 08, 05, 00, 00, DateTimeKind.Utc), 31));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 15, 05, 00, 00, DateTimeKind.Utc), 31));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 22, 05, 00, 00, DateTimeKind.Utc), 31));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 29, 05, 00, 00, DateTimeKind.Utc), 31));

        //NA Wednesday/Thursday night JW
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 02, 05, 00, 00, DateTimeKind.Utc), 448));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 09, 05, 00, 00, DateTimeKind.Utc), 448));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 16, 05, 00, 00, DateTimeKind.Utc), 448));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 23, 05, 00, 00, DateTimeKind.Utc), 448));
        WFSleep.AddRun(new GroupRun("NA", new DateTime(2025, 10, 30, 05, 00, 00, DateTimeKind.Utc), 448));

        Group SkeinGang = new Group("logo", "Skein Gang", "SG", [
            new Tuple<string,string>("discord","https://discord.gg/skeingang")
        ]);
        //NA JW CMs, Saturdays
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 9, 28, 3, 00, 00, DateTimeKind.Utc), 448));       
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 10, 05, 3, 00, 00, DateTimeKind.Utc), 448));        
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 10, 12, 3, 00, 00, DateTimeKind.Utc), 448));        
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 10, 19, 3, 00, 00, DateTimeKind.Utc), 448));
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 10, 26, 3, 00, 00, DateTimeKind.Utc), 448));

        //NA Soto CMs, Wednesdays
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 9, 29, 1, 00, 00, DateTimeKind.Utc), 31));
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 10, 09, 1, 00, 00, DateTimeKind.Utc), 31));
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 10, 16, 1, 00, 00, DateTimeKind.Utc), 31));
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 10, 23, 1, 00, 00, DateTimeKind.Utc), 31));
        SkeinGang.AddRun(new GroupRun("NA", new DateTime(2025, 10, 30, 1, 00, 00, DateTimeKind.Utc), 31));

        //EU JW CMs, Saturdays
        SkeinGang.AddRun(new GroupRun("EU", new DateTime(2025, 9, 27, 18, 30, 00, DateTimeKind.Utc), 448));
        SkeinGang.AddRun(new GroupRun("EU", new DateTime(2025, 10, 04, 18, 30, 00, DateTimeKind.Utc), 448));
        SkeinGang.AddRun(new GroupRun("EU", new DateTime(2025, 10, 11, 18, 30, 00, DateTimeKind.Utc), 448));
        SkeinGang.AddRun(new GroupRun("EU", new DateTime(2025, 10, 18, 18, 30, 00, DateTimeKind.Utc), 448));
        SkeinGang.AddRun(new GroupRun("EU", new DateTime(2025, 10, 25, 18, 30, 00, DateTimeKind.Utc), 448));

        Group VoidLounge = new Group("logo", "Void Lounge", "VL", []);

        Group MookChivalry = new Group("logo", "Mook Chivalry", "", [
            new Tuple<string,string>("twitch","https://twitch.tv/mookchivalry")
        ]);
        //EU Mondays
        MookChivalry.AddRun(new GroupRun("EU", new DateTime(2025, 9, 29, 13, 00, 00, DateTimeKind.Utc), 31));
        MookChivalry.AddRun(new GroupRun("EU", new DateTime(2025, 10, 06, 13, 00, 00, DateTimeKind.Utc), 479));
        MookChivalry.AddRun(new GroupRun("EU", new DateTime(2025, 10, 13, 13, 00, 00, DateTimeKind.Utc), 31));
        MookChivalry.AddRun(new GroupRun("EU", new DateTime(2025, 10, 20, 13, 00, 00, DateTimeKind.Utc), 31));
        MookChivalry.AddRun(new GroupRun("EU", new DateTime(2025, 10, 27, 13, 00, 00, DateTimeKind.Utc), 31));

        Group CUTE = new Group("logo", "Cruel Unending Tyrannic Entity", "CUTE", []);
        //EU JW Wednesdays
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 1, 18, 00, 00, DateTimeKind.Utc), 448));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 8, 18, 00, 00, DateTimeKind.Utc), 448));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 15, 18, 00, 00, DateTimeKind.Utc), 448));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 22, 18, 00, 00, DateTimeKind.Utc), 448));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 29, 18, 00, 00, DateTimeKind.Utc), 448));

        //EU SotO Thursdays
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 2, 18, 00, 00, DateTimeKind.Utc), 31));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 9, 18, 00, 00, DateTimeKind.Utc), 31));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 16, 18, 00, 00, DateTimeKind.Utc), 31));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 23, 18, 00, 00, DateTimeKind.Utc), 31));
        CUTE.AddRun(new GroupRun("EU", new DateTime(2025, 10, 30, 18, 00, 00, DateTimeKind.Utc), 31));


        Group LegendaryImpact = new Group("logo", "Legendary Impact", "PACT", [
            new Tuple<string,string>("discord","https://discord.gg/YGsWZK8vwz")
        ]);
        //EU SotO Fridays
        LegendaryImpact.AddRun(new GroupRun("EU", new DateTime(2025, 9, 26, 18, 00, 00, DateTimeKind.Utc), 31));
        LegendaryImpact.AddRun(new GroupRun("EU", new DateTime(2025, 10, 3, 18, 00, 00, DateTimeKind.Utc), 31));
        LegendaryImpact.AddRun(new GroupRun("EU", new DateTime(2025, 10, 10, 18, 00, 00, DateTimeKind.Utc), 31));
        LegendaryImpact.AddRun(new GroupRun("EU", new DateTime(2025, 10, 17, 18, 00, 00, DateTimeKind.Utc), 31));
        LegendaryImpact.AddRun(new GroupRun("EU", new DateTime(2025, 10, 24, 18, 00, 00, DateTimeKind.Utc), 31));
        LegendaryImpact.AddRun(new GroupRun("EU", new DateTime(2025, 10, 31, 18, 00, 00, DateTimeKind.Utc), 31));

        Group ODN = new Group("logo", "Orden der Nebel", "ODN", []);

        Group AllAboutCats = new Group("logo", "All About Cats", "", []);

        Group UndergroundLegends = new Group("/images/groups/uL/uLBot.png", "Underground Legends", "uL", [
            new Tuple<string,string>("discord", "https://discord.gg/undergroundlegends"),
            new Tuple<string,string>("website","https://undergroundlegends.gg")
        ]);
        //NA JW Saturday
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 10, 4, 20, 00, 00, DateTimeKind.Utc), 448));
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 10, 11, 20, 00, 00, DateTimeKind.Utc), 448));
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 10, 18, 20, 00, 00, DateTimeKind.Utc), 448));
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 10, 25, 20, 00, 00, DateTimeKind.Utc), 448));
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 11, 01, 20, 00, 00, DateTimeKind.Utc), 448));
        //NA SotO Sunday
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 10, 5, 17, 00, 00, DateTimeKind.Utc), 31));
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 10, 12, 17, 00, 00, DateTimeKind.Utc), 31));
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 10, 19, 17, 00, 00, DateTimeKind.Utc), 31));
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 10, 26, 17, 00, 00, DateTimeKind.Utc), 31));
        UndergroundLegends.AddRun(new GroupRun("NA", new DateTime(2025, 11, 02, 17, 00, 00, DateTimeKind.Utc), 31));
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

    public static List<Tuple<GroupRun, Group>> GetRegionRunsTimeRange(string r, DateTime Start, DateTime End)
    {
        List<Tuple<GroupRun, Group>> result = [];
        foreach (Group g in GroupList)
        {
            foreach (GroupRun gr in g.GetRegionRuns(r))
            {
                if (gr.GetTime() >= Start && gr.GetTime() <= End)
                {
                    result.Add(new Tuple<GroupRun, Group>(gr, g));
                }
            }
            result.Sort((Tuple<GroupRun, Group> a, Tuple<GroupRun, Group> b) =>
            {
                return a.Item1.GetTime() < b.Item1.GetTime() ? -1 : 1;
            });
        }
        return result;
    }
}
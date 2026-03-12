namespace ConvergenceCorpBlazor.Classes.Model.Records;

public static class Records
{
    //NO, change this!
    public static Dictionary<Season, List<Record>> records = new Dictionary<Season, List<Record>>();

    static Records()
    {
        records[Season.None].Add(new Record(1, Bosses.Decima, "Frank", 1, Region.NA, 1));
        records[Season.None].Add(new Record(2, Bosses.Greer, "Johnny", 2, Region.NA, 1));
        records[Season.Feb2026].Add(new Record(5, Bosses.Umbriel, "Annie", 3, Region.NA, 1));
    }
}


public record Record(int id, Bosses boss, string CommName, int GroupID, Region region, int runID)
{
}

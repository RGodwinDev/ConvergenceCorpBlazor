namespace ConvergenceCorpBlazor.Classes.Model;

public record Group(int Id, string? Logo, string Name, string? GuildTag, IEnumerable<(string, string)> Links, IEnumerable<GroupRun> Runs)
{
    public List<GroupRun> GetRegionRuns(Region region) => [.. Runs.Where(r => r.Region == region)];
    public GroupRun GetRunByID(int runid)
    {
        return Runs.Where(r => r.Id == runid).First();
    }
}

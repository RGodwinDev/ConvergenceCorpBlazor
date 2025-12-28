namespace ConvergenceCorpBlazor.Classes.Model;

public record Group(int Id, string Name, string? Logo, string? GuildTag, IEnumerable<(string, string)> Links, IEnumerable<GroupRun> Runs)
{
    public List<GroupRun> GetRegionRuns(string region) => [.. Runs.Where(r => r.Region == region)];
}

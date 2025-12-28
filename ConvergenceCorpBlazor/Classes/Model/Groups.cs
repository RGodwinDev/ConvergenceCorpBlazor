namespace ConvergenceCorpBlazor.Classes.Model;

/// <summary>
/// Collection of Group objects
/// </summary>
public static class Groups
{
    private static readonly List<Group> GroupList = [];

    public static void Add(Group group) => GroupList.Add(group);

    /// <summary>
    /// Get all of the runs from the <paramref name="region"/>
    /// </summary>
    /// <param name="region">The region you want the runs from.</param>
    /// <returns>List of GroupRuns from the given region</returns>
    public static List<(GroupRun, Group)> GetALLRegionRuns(string region) =>
        [.. GroupList
            .SelectMany(g => g
                .GetRegionRuns(region)
                .Select(run => (run, g)))
            .OrderBy(t => t.run.DateTime)];

    /// <summary>
    /// Get all of the runs from the <paramref name="region"/> between the <paramref name="start"/> and <paramref name="end"/> date.
    /// </summary>
    /// <param name="region">The region you want the runs from.</param>
    /// <param name="start">The start date of the target date range.</param>
    /// <param name="end">The end date of the target date range.</param>
    /// <returns>List of GroupRuns from the given region</returns>
    public static List<(GroupRun, Group)> GetRegionRunsTimeRange(string region, DateTime start, DateTime end) =>
        [.. GroupList
            .SelectMany(g => g
                .GetRegionRuns(region)
                .Where(r => r.DateTime >= start && r.DateTime <= end)
                .Select(run => (run, g)))
            .OrderBy(t => t.run.DateTime)];
}
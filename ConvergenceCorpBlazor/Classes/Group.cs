public class Group
{
    private List<GroupRun> Runs = [];
    private string logo;
    private string name;
    private string guildtag;
    private List<Tuple<string, string>> links;

    public Group(string logolink, string name, string guildtag, List<Tuple<string,string>> linklist)
    {
        this.name = name;
        this.guildtag = guildtag;
        this.logo = logolink;//default logo here
        this.links = linklist;
        Groups.getList().Add(this);
    }

    public List<GroupRun> GetALLRuns()
    {
        return this.Runs;
    }
    public List<GroupRun> GetRegionRuns(string region)
    {
        return [.. Runs.Where(r => r.GetRegion() == region)];
    }
    public string GetLogo()
    {
        return this.logo;
    }
    public string GetName()
    {
        return this.name;
    }
    public static List<Group> GetGroups()
    {
        return Groups.getList();
    }
    public void AddRun(GroupRun r)
    {
        Runs.Add(r);
    }

    public List<Tuple<string,string>> GetLinks()
    {
        return this.links;
    }
    public String GetGuildTag()
    {
        return this.guildtag;
    }
}
        
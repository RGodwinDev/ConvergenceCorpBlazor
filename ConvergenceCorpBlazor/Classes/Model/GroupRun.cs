/// <summary>
/// A Run
/// </summary>
public class GroupRun
{
    /// <summary>
    /// unique run id.
    /// </summary>
    public int Id { get; }
    public int GroupID{ get; }
    public string Region { get; set; }
    public DateTimeOffset DateTime { get; set; }
    public int Bosses { get; set; } = 0; //31 is all Soto, 448 is all JW     10111011111, first 5 are soto, next 3 are jw, last is voe

    public GroupRun(int id, int groupID, DateTimeOffset datetime, string region, int bosses)
    {
        this.Id = id;
        this.GroupID = groupID;
        this.Region = region;
        this.DateTime = datetime;
        this.Bosses = bosses;
        Groups.FindGroupById(groupID).AddRun(this);
    }
   
    public string GetRegion()
    {
        return this.Region;
    }
    public DateTimeOffset GetTime()
    {
        return DateTime;
    }

    public int GetBosses()
    {
        return Bosses;
    }
}
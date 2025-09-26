public class GroupRun
{
    private string region;
    private DateTime time;
    private int bosses = 0; //31 is all Soto, 448 is all JW     10111011111, first 5 are soto, next 3 are jw, last is voe
    public GroupRun(string region, DateTime t)
    {
        this.region = region;
        this.time = t;
    }
    public GroupRun(string region, DateTime t, int bosses)
    {
        this.region = region;
        this.time = t;
        this.bosses = bosses;
    }
    public string GetRegion()
    {
        return this.region;
    }
    public DateTime GetTime()
    {
        return time;
    }

    public int GetBosses()
    {
        return bosses;
    }
}
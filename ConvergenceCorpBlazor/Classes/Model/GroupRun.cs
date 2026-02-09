namespace ConvergenceCorpBlazor.Classes.Model;

/// <summary>
/// A Groups combined run for the day
/// </summary>
/// <param name="Id"></param>
/// <param name="GroupID"></param>
/// <param name="DateTime">The time the run starts</param>
/// <param name="Region">Region.None, NA, EU, CN</param>
/// <param name="Bosses">What bosses they intend to run</param>
public record GroupRun(int Id, int GroupID, DateTimeOffset DateTime, Region Region, Bosses Bosses)
{
    //list of runs associated with this specific Run
    //each completed run is a single boss.
    List<CompletedRun> CompletedRuns = new List<CompletedRun>();
    
    public void AddCompletedRun(TimeSpan time,  Bosses Boss)
    {
        CompletedRuns.Add(new CompletedRun(this.Id, time, Boss));
    }
    public List<CompletedRun> GetCompletedRuns()
    {
        return CompletedRuns;
    }
};

//    public int Bosses { get; set; } = 0; //31 is all Soto, 448 is all JW     10111011111, first 5 are soto, next 3 are jw, last is voe

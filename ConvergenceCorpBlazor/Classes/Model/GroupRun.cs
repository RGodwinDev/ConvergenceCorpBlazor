namespace ConvergenceCorpBlazor.Classes.Model;

/// <summary>
/// A Run
/// </summary>
public record GroupRun(int Id, int GroupID, DateTimeOffset DateTime, string Region, Bosses Bosses);

//    public int Bosses { get; set; } = 0; //31 is all Soto, 448 is all JW     10111011111, first 5 are soto, next 3 are jw, last is voe

namespace ConvergenceCorpBlazor.Classes.Model;

/// <summary>
/// A single boss run within a GroupRun
/// </summary>
/// <param name="RunID">The GroupRun associated</param>
/// <param name="Time">How fast the run was</param>
/// <param name="Boss">What boss for this run</param>
public record CompletedRun(int RunID, TimeSpan Time, Bosses Boss)
{
}

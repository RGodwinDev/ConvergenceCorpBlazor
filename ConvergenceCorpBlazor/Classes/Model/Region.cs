namespace ConvergenceCorpBlazor.Classes.Model
{
    /// <summary>
    /// What server is the data associated with. <br/>
    /// .None, use for getting ALL regions.<br/>
    /// .NA <br/> 
    /// .EU <br/> 
    /// .CN
    /// </summary>
    public enum Region : byte //8 bits -> 0-255
    {
        None = 0,
        NA = 1,
        EU = 2,
        CN = 3
    }
}

namespace ConvergenceCorpBlazor.Classes.Model.Rewards;
public record RewardRow(int ID, int Table, string Name, string IconURL, string WikiURL, double Quantity, double Gold, double Silver, double Bronze, string Participation, string Note)
{
    public string getWikiURL() {
        if (this.WikiURL.Length > 0)
        {
            return this.WikiURL;
        }
        else
        {
            return "/rewards";
        }
    }
            

}
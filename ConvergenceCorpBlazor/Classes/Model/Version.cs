namespace ConvergenceCorpBlazor.Classes.Model
{
    public class Version
    {
        public static string version = "1.4.0";
        public static string bootstrap = "6.0.0-alpha.1";
        public static string dotnet = Environment.Version.ToString();
        public static string serverOS = Environment.OSVersion.ToString();
        
    }
}

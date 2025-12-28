namespace ConvergenceCorpBlazor.Classes.Helper;

using Microsoft.Data.SqlClient;

public static class SQLDBC
{
    private static readonly SqlConnectionStringBuilder sqlConnectionStringBuilder =
        new()
        {
            Authentication = SqlAuthenticationMethod.ActiveDirectoryDefault,
            InitialCatalog = "CVRGFREEDB",
            Encrypt = true,
            TrustServerCertificate = false,
            ConnectTimeout = 30,
            DataSource = "tcp:cvrg.database.windows.net,1433"
        };

    public static string ConnectionString => sqlConnectionStringBuilder.ConnectionString;
}

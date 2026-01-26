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
            ConnectTimeout = 180, //30 seconds was too short when the server needed to unpause
            DataSource = "tcp:cvrg.database.windows.net,1433"
        };

    public static string ConnectionString => sqlConnectionStringBuilder.ConnectionString;

    //retry logic options.
    private static readonly SqlRetryLogicOption options = new SqlRetryLogicOption()
    {
        //number of tries before throwing an exception
        NumberOfTries = 5,
        //time between tries
        DeltaTime = TimeSpan.FromSeconds(15),
        //maximum delay before retry
        MaxTimeInterval = TimeSpan.FromSeconds(60)
    };

    //retry logic provider, use this for getting the logic.
    public static SqlRetryLogicBaseProvider sqlRetryLogicBaseProvider = SqlConfigurableRetryFactory.CreateExponentialRetryProvider(options);
}

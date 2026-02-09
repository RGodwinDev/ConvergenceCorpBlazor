namespace ConvergenceCorpBlazor.Classes.Helper;

using Microsoft.Data.SqlClient;
using System.Data;

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


    public static SqlDataReader ExecuteReader(SqlConnection conn, String commandText, CommandType commandType, params SqlParameter[] parameters)
    {
        //connection should already be open coming in.
        using (SqlCommand cmd = conn.CreateCommand()) {
            /*
             commandtypes: 
                .Text (SQL text command), Default, 
                .StoredProcedure, 
                .TableDirect

                Text: CommandText should be a standard SQL query.
                StoredProcedure: CommandText is the name of a stored procedure on the database.
                A stored procedure is a set of SQL statements that are precompiled and stored in the database.
                Basically you can do several complicated calls to the database with a single query.

                TableDirect: CommandText should be the name of a table. Returns the entire table.
                You can get multiple tables by using a comma delimited list.
             */
            cmd.CommandType = commandType;
            //commandText: the actual value of the command
            cmd.CommandText = commandText;
            //array of parameters
            cmd.Parameters.AddRange(parameters);
            
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }


}

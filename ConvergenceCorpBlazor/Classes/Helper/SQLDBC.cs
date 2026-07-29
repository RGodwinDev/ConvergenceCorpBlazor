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
        DeltaTime = TimeSpan.FromSeconds(5),
        //maximum delay before retry
        MaxTimeInterval = TimeSpan.FromSeconds(30)
    };

    //retry logic provider, use this for getting the logic.
    public static SqlRetryLogicBaseProvider sqlRetryLogicBaseProvider = SqlConfigurableRetryFactory.CreateExponentialRetryProvider(options);

    /// <summary>
    /// Execute a command to the database
    /// </summary>
    /// <param name="conn">Connection to the database. Make sure the connection status is open before running this.</param>
    /// <param name="commandText">SQL statement, ex: select * from groups;</param>
    /// <param name="commandType">Type of commands: <br />
    ///     CommandType.Text - SQL text command. Default <br />
    ///     CommandType.StoredProcedure - CommandText is the name of a stored procedure on the database. <br />
    ///     CommandType.TableDirect - Returns the entire table <br />
    ///     </param>
    /// <param name="parameters"></param>
    /// <returns>SqlDataReader - The databases response</returns>
    public static SqlDataReader ExecuteReader(SqlConnection conn, String commandText, CommandType commandType, params SqlParameter[] parameters)
    {
        //connection should already be open coming in.
        using (SqlCommand cmd = conn.CreateCommand()) {

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

namespace ConvergenceCorpBlazor.Classes.Helper
{
    using Microsoft.Data.SqlClient;
    public abstract class SQLDBC
    {
        private static SqlConnectionStringBuilder sqlConnectionStringBuilder =
            new SqlConnectionStringBuilder()
            {
                Authentication = (SqlAuthenticationMethod)9,
                InitialCatalog = "CVRGFREEDB",
                Encrypt = true,
                TrustServerCertificate = false,
                ConnectTimeout = 30,
                ["Server"] = "tcp:cvrg.database.windows.net,1433"
            };

        private static SqlConnection? sqlConnection;

        public static void makeConnection()
        {
            try
            {
                sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
            }
            catch(SqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
           
        }

        public static SqlConnection? getConnection()
        {
            if (sqlConnection == null)
            {
                Console.WriteLine("sql connection is null, make one first");
            }
            return sqlConnection;
        }

        public static void closeConnection()
        {
            if (sqlConnection != null)
            {
                try
                {
                    sqlConnection.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

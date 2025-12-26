using ConvergenceCorpBlazor.Classes.Helper;
using Microsoft.Data.SqlClient;
using ConvergenceCorpBlazor.Classes.Model;

namespace ConvergenceCorpBlazor.Classes.DBControllers
{
    public abstract class DBGroupRun
    {
        public static void GetAll()
        {
            SQLDBC.makeConnection();
            using (SqlConnection conn = SQLDBC.getConnection())
            {
                SqlCommand runsCommand = new(
                    "SELECT * FROM Runs",
                    conn);

                conn.Open();
                SqlDataReader reader = runsCommand.ExecuteReader();
                int count = 0;
                while (reader.HasRows)
                {
                    count++;
                    while (reader.Read())
                    {
                        GroupRun g = new GroupRun(reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTimeOffset(2), reader.GetString(3), reader.GetInt32(4));
                    }
                    reader.NextResult();
                }
                if (count == 0) { Console.WriteLine("There were no rows"); }
                reader.Close();
                SQLDBC.closeConnection();
            }
        }
    }
}

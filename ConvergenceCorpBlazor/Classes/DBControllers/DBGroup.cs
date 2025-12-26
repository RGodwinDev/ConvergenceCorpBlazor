using ConvergenceCorpBlazor.Classes.Helper;
using Microsoft.Data.SqlClient;
using ConvergenceCorpBlazor.Classes.Model;

namespace ConvergenceCorpBlazor.Classes.DBControllers
{
    public abstract class DBGroup
    {
        public static void GetAll()
        {
            try
            {
                SQLDBC.makeConnection();
                List<Model.Group> groups = new List<Model.Group>();
                using (SqlConnection conn = SQLDBC.getConnection())
                {
                    SqlCommand command = new(
                        "SELECT * FROM Groups;",
                        conn);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    int rowcount = 0;
                    while (reader.HasRows)
                    {
                        rowcount++;
                        while (reader.Read())
                        {   //the group is added to GroupList and GroupDict in the Group Constructor.
                            new Model.Group(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                        }
                        reader.NextResult();
                    }

                    if (rowcount == 0) { Console.WriteLine("There were no rows"); }
                    reader.Close();

                    SqlCommand linkCommand = new(
                        "SELECT * FROM Links",
                        conn);
                    SqlDataReader linkReader = linkCommand.ExecuteReader();
                    int linkcount = 0;
                    while (linkReader.HasRows)
                    {
                        linkcount++;
                        while (linkReader.Read())
                        {
                            Group g = Groups.FindGroupById(linkReader.GetInt32(0));
                            //1 is the actual link, 2 is the type (discord, twitch, etc...)
                            g.AddLink(new Tuple<string, string>(linkReader.GetString(1), linkReader.GetString(2)));
                        }
                        linkReader.NextResult();
                        
                        
                    }
                    linkReader.Close();
                    SQLDBC.closeConnection();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        } //end GetAll()
    } //end DBGroup
} //end namespace

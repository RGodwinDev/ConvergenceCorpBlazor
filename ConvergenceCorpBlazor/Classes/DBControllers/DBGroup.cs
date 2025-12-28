using ConvergenceCorpBlazor.Classes.Helper;
using ConvergenceCorpBlazor.Classes.Model;
using Microsoft.Data.SqlClient;

namespace ConvergenceCorpBlazor.Classes.DBControllers;

public static class DBGroup
{
    public static void GetAll()
    {
        try
        {
            using var conn = new SqlConnection(SQLDBC.ConnectionString);
            conn.Open();

            var links = GetLinks(conn);
            var runs = GetRuns(conn);

            using var command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Groups;";

            using var reader = command.ExecuteReader();
            if(!reader.HasRows)
            {
                Console.WriteLine("There were no rows");
                return;
            }
            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                if (!links.TryGetValue(id, out var groupLinks))
                    groupLinks = [];

                if (!runs.TryGetValue(id, out var groupRuns))
                    groupRuns = [];

                Groups.Add(new Group(id, reader.GetString(1), reader.GetString(2), reader.GetString(3), groupLinks, groupRuns));
            }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }

    private static Dictionary<int, List<(string, string)>> GetLinks(SqlConnection conn)
    {
        var links = new Dictionary<int, List<(string, string)>>();
        using var linkCommand = conn.CreateCommand();
        linkCommand.CommandText = "SELECT * FROM Links";
        using var linkReader = linkCommand.ExecuteReader();
        while (linkReader.Read())
        {
            var id = linkReader.GetInt32(0);
            var link = (linkReader.GetString(1), linkReader.GetString(2));
            if (!links.TryGetValue(id, out var currentLinks))
            {
                links.Add(id, [link]);
            }
            else
            {
                currentLinks.Add(link);
            }
        }
        return links;
    }

    public static Dictionary<int, List<GroupRun>> GetRuns(SqlConnection conn)
    {
        var runs = new Dictionary<int, List<GroupRun>>();
        using var runsCommand = conn.CreateCommand();
        runsCommand.CommandText = "SELECT * FROM Runs";
        using var reader = runsCommand.ExecuteReader();
        while (reader.Read())
        {
            var groupId = reader.GetInt32(1);
            var run = new GroupRun(reader.GetInt32(0), groupId, reader.GetDateTimeOffset(2), reader.GetString(3), (Bosses)reader.GetInt32(4));
            if(!runs.TryGetValue(groupId, out var currentRuns))
            {
                runs.Add(groupId, [run]);
            }
            else
            {
                currentRuns.Add(run);
            }
        }

        return runs;
    }
}

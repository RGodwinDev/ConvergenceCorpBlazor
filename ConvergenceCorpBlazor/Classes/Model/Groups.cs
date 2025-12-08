using Microsoft.Data.SqlClient;

/// <summary>
/// Collection of Group objects
/// </summary>
public static class Groups
{
    private static List<Group> GroupList = [];

    //int is the group id
    private static Dictionary<int, Group> GroupDict = new Dictionary<int, Group>();
    
    public static void StartGroup2(SqlConnection connection)
    {
        Console.WriteLine("Connecting to DB...");
        using (connection)
        {
            SqlCommand command = new(
                "SELECT * FROM Groups;",
                connection );

            connection.Open();
            Console.WriteLine("Connection achieved!");
            Console.WriteLine("Rallying Groups!");
            SqlDataReader reader = command.ExecuteReader();
            int rowcount = 0;
            while (reader.HasRows)
            {
                rowcount++;
                while (reader.Read())
                {
                    new Group(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                reader.NextResult();
            }
            if(rowcount == 0) { Console.WriteLine("There were no rows"); }
            reader.Close();

            Console.WriteLine("Linking...");
            SqlCommand linkCommand = new(
                "SELECT * FROM Links",
                connection );
            SqlDataReader linkReader = linkCommand.ExecuteReader();
            int linkcount = 0;
            while (linkReader.HasRows)
            {
                linkcount++;
                while (linkReader.Read())
                {
                    Group g = Groups.FindGroupById(linkReader.GetInt32(0));
                    //1 is the actual link, 2 is the type (discord, twitch, etc...)
                    g.AddLink(new Tuple<string,string>(linkReader.GetString(1), linkReader.GetString(2)));
                }
                linkReader.NextResult();
            }
            linkReader.Close();
            connection.Close();
        }
    }

    public static void InitializeRuns(SqlConnection connection)
    {
        using (connection)
        {
            SqlCommand runsCommand = new(
                "SELECT * FROM Runs",
                connection );

            connection.Open();
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
            connection.Close();
        }
    }

    /// <summary>
    /// Get the List of Groups
    /// </summary>
    /// <returns></returns>
    public static List<Group> getList()
    {
        return GroupList;
    }

    /// <summary>
    /// Get all of the runs from the region r
    /// </summary>
    /// <param name="r">The region you want the runs from.</param>
    /// <returns>List of GroupRuns from the given region</returns>
    public static List<Tuple<GroupRun, Group>> GetALLRegionRuns(string r)
    {
        List<Tuple<GroupRun, Group>> result = [];

        foreach (Group g in GroupList)
        {
            foreach (GroupRun gr in g.GetRegionRuns(r))
            {
                result.Add(new Tuple<GroupRun, Group>(gr, g));
            }
        }
        result.Sort((Tuple<GroupRun, Group> a, Tuple<GroupRun, Group> b) =>
        {
            return a.Item1.GetTime() < b.Item1.GetTime() ? -1 : 1;
        });
        return result;
    }

    public static List<Tuple<GroupRun, Group>> GetRegionRunsTimeRange(string r, DateTime Start, DateTime End)
    {
        List<Tuple<GroupRun, Group>> result = [];
        foreach (Group g in GroupList)
        {
            foreach (GroupRun gr in g.GetRegionRuns(r))
            {
                if (gr.GetTime() >= Start && gr.GetTime() <= End)
                {
                    result.Add(new Tuple<GroupRun, Group>(gr, g));
                }
            }
            result.Sort((Tuple<GroupRun, Group> a, Tuple<GroupRun, Group> b) =>
            {
                return a.Item1.GetTime() < b.Item1.GetTime() ? -1 : 1;
            });
        }
        return result;
    }
    public static void AddGroupToGroups(Group G)
    {
        GroupDict.Add(G.Id, G);
    }
    public static Group FindGroupById(int id)
    {
        return GroupDict[id];
    }
}
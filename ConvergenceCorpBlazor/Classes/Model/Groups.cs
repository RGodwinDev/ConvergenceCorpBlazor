using Microsoft.Data.SqlClient;
namespace ConvergenceCorpBlazor.Classes.Model
{
    /// <summary>
    /// Collection of Group objects
    /// </summary>
    public static class Groups
    {
        private static List<Group> GroupList = [];

        //int is the group id
        private static Dictionary<int, Group> GroupDict = new Dictionary<int, Group>();

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
}
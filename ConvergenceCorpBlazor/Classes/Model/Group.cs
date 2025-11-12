using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// A Group object.
/// </summary>
[Table("Groups")]
[PrimaryKey(nameof(Id))]
public class Group
{
    /// <summary>
    /// List of GroupRuns in the Group
    /// </summary>
    private List<GroupRun> Runs = [];
    
    public int Id { get; }

    /// <summary>
    /// Link to the logo.
    /// </summary>
    public string? Logo { get; set; }

    /// <summary>
    /// The Group's name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The Group's tag, 0-4 Characters.
    /// </summary>
    public string? Guildtag { get; set; }

    /// <summary>
    /// List of the Groups Links
    /// </summary>
    private List<Tuple<string, string>> links = new List<Tuple<string, string>>();

    public Group(int id, string logo, string name, string guildtag)
    {
        this.Id = id;
        this.Name = name;
        this.Guildtag = guildtag;
        this.Logo = logo;
        Groups.getList().Add(this);
        Groups.AddGroupToGroups(this);
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="logolink">The link to the logo.</param>
    /// <param name="name">The Groups Name.</param>
    /// <param name="guildtag">The Groups Guild Tag (1-4 Characters).</param>
    /// <param name="linklist">List of Links.</param>
    public Group(int id, string logo, string name, string guildtag, List<Tuple<string, string>> linklist)
    {
        this.Id = id;
        this.Name = name;
        this.Guildtag = guildtag;
        this.Logo = logo;//default logo here
        this.links = linklist;
        Groups.getList().Add(this);
        Groups.AddGroupToGroups(this);
    }

    /// <summary>
    /// Gets ALL the runs for this Group.
    /// </summary>
    /// <returns>List of GroupRuns</returns>
    public List<GroupRun> GetALLRuns()
    {
        return this.Runs;
    }

    /// <summary>
    /// Gets all the GroupRuns from a Region for this Group.
    /// </summary>
    /// <param name="region">'NA' or 'EU'</param>
    /// <returns>List of GroupRuns</returns>
    public List<GroupRun> GetRegionRuns(string region)
    {
        return [.. Runs.Where(r => r.GetRegion() == region)];
    }

    /// <summary>
    /// Gets the link to the logo of the Group.
    /// </summary>
    /// <returns>string, link to the logo.</returns>
    public string GetLogo()
    {
        if (this.Logo != null)
        {
            return this.Logo;
        }
        return "";
    }

    /// <summary>
    /// Get the Name of the Group.
    /// </summary>
    /// <returns>String name</returns>
    public string GetName()
    {
        return this.Name;
    }

    /// <summary>
    /// Get ALL Groups.
    /// </summary>
    /// <returns>List of Groups</returns>
    public static List<Group> GetGroups() //why is this even here?
    {
        return Groups.getList();
    }

    /// <summary>
    /// Add a run to the Group
    /// </summary>
    /// <param name="r">The GroupRun to be added.</param>
    public void AddRun(GroupRun r)
    {
        Runs.Add(r);
    }

    /// <summary>
    /// Add a link to the Group.
    /// </summary>
    /// <param name="link">first:type('discord', 'twitch', 'website'), second:link</param>
    public void AddLink(Tuple<string, string> link)
    {
        this.links.Add(link);
    }

    /// <summary>
    /// Gets all the links of this Group
    /// </summary>
    /// <returns>List of Links</returns>
    public List<Tuple<string, string>> GetLinks()
    {
        return this.links;
    }

    /// <summary>
    /// Get the Guild Tag of the Group
    /// </summary>
    /// <returns>String</returns>
    public String GetGuildTag()
    {
        if (this.Guildtag != null)
        {
            return this.Guildtag;
        }
        return "";
    }

}
        
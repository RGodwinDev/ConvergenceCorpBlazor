namespace ConvergenceCorpBlazor.Classes.Model.Game;

//every NPC has a list of skills
public class Skill
{
    public String Name;
    public String Description;
    public String YTLink; //only the video id.
    public String ID;

    public Skill(String id,String name, String desc, String ytlink)
    {
        this.Name = name;
        this.Description = desc;
        this.YTLink = ytlink;
        this.ID = id;
    }
}

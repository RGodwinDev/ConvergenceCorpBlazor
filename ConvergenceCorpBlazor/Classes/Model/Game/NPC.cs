namespace ConvergenceCorpBlazor.Classes.Model.Game;

public class NPC
{
    public string Name { get; set; }
    public string Description {  get; set; }
    public List<Skill> SkillList { get; set; }
    int HP { get; set; } = 0;

    public NPC(string n, string d, List<Skill> skills)
    {
        Name = n;
        Description = d;
        SkillList = skills;
    }
}
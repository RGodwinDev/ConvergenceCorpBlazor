namespace ConvergenceCorpBlazor.Classes.Model.Game;

public class EnemyNPC : NPC
{
    public int HP { get; set; } = 0;
    public EnemyNPC(string Name, string Description, int HP, List<Skill> skills) : base(Name, Description, skills)
    {
        this.HP = HP;
    }
}

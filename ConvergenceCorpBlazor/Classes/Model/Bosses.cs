namespace ConvergenceCorpBlazor.Classes.Model;

[Flags]
public enum Bosses : int
{
    None = 0,

    // SoTo
    DemonKnight = 0b1,
    DeathWing   = 0b10,
    HellSister  = 0b100,
    Sorrow      = 0b1000,
    Umbriel     = 0b10000,

    //Placeholder = 0b000000,

    // JW
    Decima      = 0b1000000,
    Greer       = 0b10000000,
    Ura         = 0b100000000,

    //Placeholder = 0b1000000000,

    // VoE
    VoE         = 0b10000000000,
}

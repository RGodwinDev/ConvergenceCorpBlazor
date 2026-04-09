using static System.Net.WebRequestMethods;

namespace ConvergenceCorpBlazor.Classes.Model.Game;

public class Boss : EnemyNPC
{
    public Boss(string Name, string Description, int HP, List<Skill> skills) : base(Name, Description, HP, skills)
    {

    }

    public static Boss getBoss(Bosses b)
    {
        return bosslist[b];
    }

    public static Dictionary<Bosses, Boss> bosslist = new Dictionary<Bosses, Boss>
    {
        {Bosses.DemonKnight, new Boss("Demon Knight", "A Knight!", 90000000,
            [
                new Skill("DK-Passive", "Wrathful Aura",
                    "\tDemon Knight has an aura that hurts players nearby. " +
                    "When the breakbar on DK is up, this aura hurts significantly more and at longer range than normal. " +
                    "Break the breakbar as fast as you can to reduce Wrathful Aura's strength.",
                    "JI7kmEUpNgY"
                    ),
                new Skill("DK-1", "Wrath of Firmament",
                    "\tDemon Knight shoots a beam of light into the air and calls down several meteors. Each of the meteors targets a player.\n\n" +
                    "\tIf you are targeted by a meteor, mount up and run far away from the main group.",
                    ""
                    ),
                new Skill("DK-2", "Shards of Wrath",
                    "\tSecondary meteors that fall around the main Wrath of Firmament meteor.",
                    ""
                    ){
                },
                new Skill("DK-3", "Tyrant's Contempt", 
                    "\tDemon Knight fires 6 orbs. " +
                    "Each one creates an aoe then explodes into 6 more orbs.\n" +
                    "\tEach of the 36 orbs move outward in a circle around their original orbs explosion spot then back in. " +
                    "The orbs pull anyone they touched to the location they are converging on.\n" +
                    "\tDemon Knight follows this up by using Callous Retribution on the biggest group caught by the orbs.",
                    ""
                    ),
                new Skill("DK-4", "Tyrant's Teeth", 
                    "\tDemon Knight shoots out multiple lines across the ground, damaging anyone standing in the way. " +
                    "After a few seconds, they pulse out more damage.\n" +
                    "\tDemon Knight shoots out more lines the.",
                    ""
                    ),
                new Skill("DK-5", "Callous Retribution", 
                    "Demon Knight fires a large red beam at the largest group caught by Tyrant's Contempt.",
                    ""
                    ),
                new Skill("DK-6", "Sweeping Judgment", 
                    "",
                    ""
                    ),
                new Skill("DK-7", "Telluric Wrath", 
                    "Demon Knight creates 3 rings around him. The middle fires first, then the inner and outer rings at the same time.",
                    ""
                    )
            ]) },
        {Bosses.DeathWing, new Boss("Dreadwing", "A Dragon!", 9000000,
            [
                new Skill("DW-1","Branded Rain of Fire",
                    "Dreadwing flys up and shoots 5 fireballs in an arc. " +
                    "After finishing the fireball arc, Dreadwing slams down on the ground.",""),
                new Skill("DW-2","Cracks in Reality",
                    "Dreadwing rips a crack in reality. Walking over a crack knocks you to the side.",""),
                new Skill("DW-3","Tail Swipe",
                    "Dreadwing swipes their tail in an arc, knocking back players.",""),
                new Skill("DW-4","Charge", 
                    "Dreadwing charges in a random direction, knocking away anyone in their way.",
                    ""),
                new Skill("DW-5","Breathe Fire", 
                    "Dreadwing breates a cone of flames in front of him.",""),
                new Skill("DW-6","Shearing Winds", 
                    "Dreadwing flaps their wings, pushing back anyone caught in the high winds. " +
                    "Break the breakbar to stop Sorrow from flapping!",
                    ""),
                new Skill("DW-7","Fireball", 
                    "Dreadwing shoots out a large fireball that bounces across the ground. Leaves behind a trail of fire aoes.",
                    "")
            ]) },
        {Bosses.HellSister, new Boss("Hell Sister", "A Demon Lady!", 9000000,
            [
                new Skill("HS-1", "Kryptis Blast", 
                    "Hell Sister fires a cone attack between every other skill she casts.",""),
                new Skill("HS-2", "Abyss Rift", 
                    "Hell Sister tears open 2 Abyss Rifts along the ground, going in opposite directions. </br>" +
                    "Each rift splits into 2 additional rifts, creating a hexagonal pattern. " +
                    "These rifts hit hard and will push you even while you're downed.",""),
                new Skill("HS-3", "Deadly Attraction", 
                    "Hell Sister glares at anyone looking in her direction. " +
                    "Hits hard, taunts, and applies 5 stacks of confusion. " +
                    "This can be negated with blocks." +
                    "The actual hit is VERY fast, usually within 1 second of the animation starting.", ""),
                new Skill("HS-4", "Ball of Torment", 
                    "Hell Sister shoots out a ball. " +
                    "Each time the ball hits the ground, it splits and bounces in different directions. " +
                    "Very hard to see and can wipe a group if the orbs are grouped up.", 
                    ""),
                new Skill("HS-5", "Riftwalk", "Hell Sister blinks to a new location.", "")
            ]) },
        {Bosses.Sorrow, new Boss("Sorrow", "A Spicy Dragon!", 9000000,
            [
                new Skill("Sor-1", "Cosmic Energy", 
                    "\tA debuff applied by some of Sorrow's skills. Causes Low Gravity and increased move speed. " +
                    "Fall damage is NOT decreased.",""),
                new Skill("Sor-2", "Stormfall", 
                    "\tFissures of astral force that last for a few seconds. Deal significant damage. These activate after every skill that Sorrow uses.", ""),
                new Skill("Sor-3", "Gravity Bomb",
                    "\tSorrow creates a field that inflicts burning and Cosmic Energy. " +
                    "When used as part of Sorrow Barrage, Sorrow's Brood will spawn inside.",""),
                new Skill("Sor-4", "Sorrow Barrage", 
                    "\tSorrow jumps into the air and fires 5 Gravity Bombs in an arc. " +
                    "After finishing the Gravity Bomb arc, Sorrow slams down crushing anyone beneath them.",""),
                new Skill("Sor-5", "Tail Swipe", 
                    "Sorrow swipes with their tail in an arc, knocking back anyone hit.",
                    ""),
                new Skill("Sor-6", "Tail Slash", 
                    "\tFollows Tail Swipe. Sorrow jumps into the air and slashes down with their tail. " +
                    "Anyone hit is knocked back.",
                    ""),
                new Skill("Sor-7", "Charge", 
                    "\tSorrow charges in a random direction, knocking away anyone in their path.",
                    ""),
                new Skill("Sor-8", "Shearing Winds", 
                    "\tSorrow flaps their wings, knocking back players caught in their high winds. " +
                    "Break the breakbar to stop Sorrow from flapping!", ""),
                new Skill("Sor-9", "71654", "", ""),
                new Skill("Sor-10", "Gravity Well", 
                    "\tSorrow slams their left hand, then their right hand on the ground, knocking down anyone hit. " +
                    "This creates a shockwave and a Gravity Field.", ""),
                new Skill("Sor-11", "Gravity Field", 
                    "\tCreated by Gravity Well, the Gravity Field spins counterclockwise and pulls everyone inwards. " +
                    "Inflicts slow, confusion, and torment.", 
                    "")
            ]) },
        {Bosses.Umbriel, new Boss("Umbriel", "A Demon!", 9000000,
            [
                new Skill("Umb-1", "Bleeding Edge", 
                    "\tUmbriel winds up for a second and blasts a cone directly infront of him. Inflicts 10 stacks of Bleeding.", 
                    "npeqMF-nFhc"),
                new Skill("Umb-2", "Scouring Blade", 
                    "\tUmbriel blasts a cone towards a targeted player. " +
                    "If the targeted player is out of Umbriel's melee range, he will dash towards them first.",
                    "5L2CJZ9Hkso"),
                new Skill("Umb-3", "Rending Storm", 
                    "\tUmbriel spawns several axes that move around. " +
                    "The axes pull, immobilize, cripple, bleed, and expose you. " +
                    "If you're caught by an axe, use any condi cleanses you have to escape. " +
                    "If you still can't get out then use your Warclaw or Skyscale.", 
                    "X9Cqe6cuycQ"),
                new Skill("Umb-4", "Dissecting Dance", 
                    "\tUmbriel spins around swinging his axes wildly. Inflicts Bleeding.",
                    "5Wka4WAASss"),
                new Skill("Umb-5", "Frightening Speed",  
                    "\tStarting at 75%, Umbriel will create 5 orange areas with roman numerals over them. " +
                    "When these appear, your #1 goal is to get out. " +
                    "Umbriel will dash to each orange circle in order of the roman numerals, dealing massive unblockable damage to anyone still inside.",
                    "DiT-yvmllGQ"),
                new Skill("Umb-6", "Dread Visage", 
                    "\tStarting at 50%, Umbriel charges a large eye over himself. " +
                    "After a few seconds the eye triggers, inflicting 25 stacks of Vulnerability and several seconds of Fear to anyone looking towards him. " +
                    "To avoid this, simply turn your character away from Umbriel.",
                    "6p_aKUAS0aI")/*,
                new Skill("Umb-7", "Frightening Speed & Dread Visage",
                    "At 25%, Umbriel will use Dread Visage when using Frightening Speed. "+
                    "Look away from all of the circles until the eye triggers.",
                    "") //get a decent video of the combined FS and DV.
            */
            ]) },
        {Bosses.Decima, new Boss("Decima", "An electric Rock", 9000000,
            [
                new Skill("Dec-passive", "Chorus of Thunder", 
                    "\tDecima calls out to the storm, which responds with a thundering chorus. " +
                    "This consumes all stacks of Peal of Discord and Peal of Harmony.\n" +
                    "\tEach stack of Peal of Discord lets Decima target the closest untargeted player with Chorus of Thunder.\n" +
                    "\tEach stack of Peal of Harmony lets Decima target an uncharged conduit near the farthest player.\n" +
                    "\tThunderbolts deal increased damage to secondary targets in their area.",
                    ""),
                new Skill( "Dec-1", "Fluxlance (Orange)",
                    "If you're targeted by an orange FluxLance, just try not to hit one of the pylons with it. " +
                    "Hitting a pylon will charge it.",
                    "/images/JW/Decima/DecFluxLanceRed.png"),
                new Skill("Dec-2", "Fluxlance (Red)",
                    "If you're targeted by a red Fluxlance, you should hide behind a pylon that is away from the group. " +
                    "Everyone else should avoid getting hit by the red Fluxlance as it WILL 1-shot you!",
                    "PnKY-nIVVZ8"),
                new Skill("Dec-3", "Foreshock", 
                    "Decima stomps to the left, then the right, and then in front of her.", ""),
                new Skill("Dec-4", "Mainshock", "Decima slams an orb of arcane flux into the ground, causing the ground to rupture up around her. " +
                    "The ground ruptures from the front to the back." +
                    "This applies Vulnerability and Knockback.", ""),
                new Skill("Dec-5", "Aftershock", "Electric explosions slowly explode outward to the edge of the arena then come back inwards.",
                    ""),
                new Skill("Dec-6", "Seismic Crash", 
                    "Decima jumps and slams into the ground causing the immediate vicinity to erupt in jagged rocks and pyrite. " +
                    "This deals more damage the closer you are to Decima. " +
                    "Players hit by the attack will be pushed outward toward the Fulgent Fences.",
                    ""),
                new Skill("Dec-7", "Earthrend", "Decima jumps up and attacks beyond the pylons. " +
                    "The ground erupts with jagged rocks and pyrite. " +
                    "Players caught in the attack will be pulled inwards towards the Fulgent Fences.",
                    "oKg07_kHrIo"),
                new Skill("Dec-8", "Fluxlance Fusilade (5x Orange)", "" +
                    "After 50%, Decima will shoot 5 Fluxlances at a time. " +
                    "Players with orange Fluxlances should spread out and try not to hit pylons. " +
                    "Taking damage from more than 1 orange Fluxlance can be dangerous.", 
                    ""),
                new Skill("Dec-9", "Fluxlance Fusilade (4x Orange 1x Red)", 
                    "After 50%, Decima will shoot 5 Fluxlances at a time. " +
                    "The player with the red Fluxlance should run and hide behind a pylon that is away from the group. " +
                    "The players with orange Fluxlances should spread out and try not to hit pylons. " +
                    "Taking damage from more than 1 orange Fluxlance can be dangerous.",
                    "PnKY-nIVVZ8"),
                new Skill("Dec-10", "Swirling Winds", 
                    "Decima channels storm winds to push players around. " +
                    "She does this in combination with Fluxlance Fusilade to make the targeted players hit a pylon with their arrows.", 
                    ""),
                new Skill("Dec-11", "Sparking Aura", 
                    "Green circles spawn from any charged pylons and move towards Decima. " +
                    "These greens deal a small amount of Sparking Aura damage to any person standing inside it.", 
                    "")
            ]) },
        {Bosses.Greer, new Boss("Greer", "A stinky Rock", 9000000,
            [
                new Skill("Gre-1", "Eruption of Rot", 
                    "Players will randomly get green circles on them. " +
                    "The icon above indicates how many players need to stand inside the circle to satisfy it. " +
                    "Failing to satisfy the Eruption of Rot will knock up everyone inside and spawn a Noxious Blight. " +
                    "There is no penalty to stacking greens.", ""),
                new Skill("Gre-2", "Noxious Blight", 
                    "A Large purple pool of corruption. " +
                    "Standing inside will currupt two boons into conditions every tick.", 
                    ""),
                new Skill("Gre-3", "Aura of Corruption", 
                    "Greer has a purple aoe underneath him for the whole fight. " +
                    "Standing inside it will give you poison.", 
                    ""),
                new Skill("Gre-4", "Blob of Blight", 
                    "Greer spawns large purple and gold orbs that chase the furthest people from him. " +
                    "The orbs emit smaller orbs in all directions. " +
                    "If a large orb hits a player, it becomes stationary.", 
                    ""),
                new Skill("Gre-5", "Scattering Sporeblast",
                    "Greer aims with his left arm and blasts several spores in a cone in front of him.", 
                    ""),
                new Skill("Gre-6", "Rain of Spores", 
                    "Greer leans forward and shovels up some spores from the ground with his hands. " +
                    "He then holds them up and fires the spores.", 
                    ""),
                new Skill("Gre-7", "Rot the World", 
                    "Greer uses this skill when his breakbar is up. " +
                    "He raises up his hand and emits orbs across the whole arena. " +
                    "The orbs explode when they land.", 
                    ""),
                new Skill("Gre-8", "Sweep the Mold", 
                    "Greer raises his left arm to the right and sweeps it across the ground." +
                    "This applies bleeding, poison, and knocks back.", 
                    ""),
                new Skill("Gre-9", "Rake the Rot", 
                    "Follows Sweep the Mold. " +
                    "Greer raises his left arm to the left and rakes it across the ground in front of himself.", 
                    ""),
                new Skill("Gre-10", "Stomp the Convergence", 
                    "Follows Rake of Rot. " +
                    "Greer raises up and stomps the ground three times.", 
                    ""),
                new Skill("Gre-11", "Ripples of Rot", 
                    "Greer casts two waves on either side of him. Getting hit will push you back." +
                    "He also creates fences at the edge of the attack.", 
                    ""),
                new Skill("Gre-12", "Cage of Decay", 
                    "Greer shoots out 5 Cage of Decay projectiles that travel along the ground. " +
                    "When they reach their destination, it becomes a Noxious Blight with Ripple of Rot fences surrounding it.", 
                    ""),
                new Skill("Gre-13", "Enfeebling Miasma", 
                    "Greer leans forward and roars, spewing out several purple aoes in a clockwise spiral pattern." +
                    "The Miasma will corrupt your boons.",
                    ""),
                new Skill("Gre-14", "Seeds of Decay", 
                    "When the breakbar is broken, fragments of Greer's armor rain down around the arena. " +
                    "Smaller pieces explode on impact while larger fragments transform into titanspawn.", 
                    "")


            ]) },
        {Bosses.Ura, new Boss("Ura", "A sulfur Rock", 90000000,
            [
                new Skill("Ura-1", "Rising Pressure", 
                    "Ura gains stacks of Rising Pressure. " +
                    "Every stack gives Ura 5% increased damage and damage reduction. " +
                    "Breaking her breakbar removes all of the stacks of Rising Pressure.", 
                    ""),
                new Skill("Ura-2", "Scalding Aura", 
                    "Ura has a super heated puddle of acid underneath her. Applies Burning", 
                    ""),
                new Skill("Ura-3", "Slam", 
                    "Ura slams side to side, then raises up and slams a cone in front of her.", 
                    ""),
                new Skill("Ura-4", "Pressure Blast", 
                    "Ura reaches forwards with her hands and Pressure Blasts directly in front of her. " +
                    "Anyone hit will be bubbled and lifted. " +
                    "Bubbles spread to nearby people, meaning you can get hit even if you're not near the initial circle.", 
                    ""),
                new Skill("Ura-5", "Propel", 
                    "Ura leaps towards the furthest player. Massive damage on landing.", 
                    ""),
                new Skill("Ura-6", "Sulfuric Acid",
                    "Deals damage every second and applies Exposed every 10 seconds.",
                    ""),
                new Skill("Ura-7", "Sulfuric Froth", 
                    "Sulfuric Acid spills out of Ura as she moves around, leaving behind puddles of Sulfuric Froth. Applies Sulfuric Acid.", 
                    ""),
                new Skill("Ura-8", "Acid Spray", 
                    "Ura sprays acid from her hands. Applies Sulfuric Acid.", 
                    ""),
                new Skill("Ura-9", "Toxic Geyser", 
                    "Toxic Geysers spawn around the arena. They apply Poison and Sulfuric Acid. ",
                    "JmutPAFDhSM")
            ]) }
    };
}
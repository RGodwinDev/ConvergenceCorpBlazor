using ConvergenceCorpBlazor.Components.Pages.SecretsOfTheObscure.Pre;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace ConvergenceCorpBlazor.Classes.Model.Game.Festivals.FourWinds
{
    public record GauntletBosses(string Name, string About, List<string> Skills)
    {
        //shouldve done gauntlet encounters
        //where each encounter has a name, about, list of enemies, and each enemy in the list has its own skills and about section.
        //As it is, encounters with multiple enemies just dont work and need to be done manually.
        public static List<GauntletBosses> Bosses = [
            new GauntletBosses("Halmi Hammerfell",
                "A norn pirate with a big anchor for a hammer. Avoid his big smash by interupting it or moving behind him.",
                [
                    "Mighty Smash - Halmi charges a large smash, dealing massive damage in a cone infront of him and knocking down anyone caught."
                ]),
            new GauntletBosses("Doobroosh",
                "A Quaggan with a nasty temprament, the more you hit him the bigger and stronger he gets. Kite him around the arena as he does not have any ranged attacks.",
                [
                    "Slash - Doobroosh slashes with his claws."
                ]),
            new GauntletBosses("Windcaller Kieldia",
                "Every few seconds Kieldia will summon another tornado. Kieldia herself doesn't do much damage but will eventually fill the arena with tornados. Defeat her before that happens or you will get perma knockback from the amount of them.",
                [
                    "Wind Blast - A ranged attack that knocks back.",
                    "Summon Tornado - Summons a tornado.",
                    "Gale - The tornado deals medium damage and knocks back."
                ]),
            new GauntletBosses("Suriel the Blazing Light", 
                "Suriel trains year round in Lion's Arch for the Crown Pavilion. Her Blazing Light makes her Invulnerable. Suriel loses Blazing Light by walking through the shadow circles on the ground.", 
                [
                    "Radiant Bolt - A projectile that inflicts Weakness and Crippled",
                    "Sanctify - Suriel casts a cone of  infront of her.",
                    "Solar Flare - Undodgable, unblockable, arena wide AOE that deals massive damage. " +
                    "Avoid the damage by standing within the shadow circles. Also reapplies Blazing Light to Suriel."
                ]),
            new GauntletBosses("Tyre Ragemaw", "A charr warrior from the Black Citadel wielding a greatsword. " +
                "He deals damage Inversely to how much HP he has left." +
                " This means low damage at 100%, lots of damage below 10%.", 
                [
                    "Chop - Tyre chops at you.",
                    "Double Chop - Tyre chops at you twice.",
                    "Triple Chop - Tyre chops at you three times.",
                    "Throw Axe - Tyre throws an axe at you, crippling.",
                    "Savage Leap - Tyre leaps at you, stabbing with his sword."
                ]),
            new GauntletBosses("Masticus", 
                "Masticus is a Warg with a ton of HP. Run around collecting orbs to increase your damage.", 
                [
                    "Rend - Masticus bites. A stack of Rend is applied with each bite, which decreases your toughness. " +
                    "Rend can be removed with a Condi Cleanse.",
                    "Lunge - Masticus lunges at you, closing a small gap.",
                    "Slash - Masticus slashes with both of his claws, once after the other."
                ]),
            new GauntletBosses("Salazan",
                "An asura who wields deadly fire skills, stay inside the fire ring while dodging his other skills. " +
                "Bringing a ranged build makes this fight much easier.", 
                [
                    "Enflame - Salazan puts several ground aoes under your feet. Avoid them.",
                    "Flame Cage - Salazan encloses you in a flame circle, if you touch a side it deals massive damage.",
                    "Flame Wave - Salazan shoots out slow moving flames towards you. Avoid them."
                ]),
            new GauntletBosses("The crew of the pirate ship Ravenous", "", []), //The pirate crew will be done manually, as its too complicated.
            new GauntletBosses("Subject 7", 
                "An ooze that splits into more oozes as it loses hp. " +
                "Kill the main body quickly or the amount of oozes will overwhelm you.", 
                [
                    "Power Spit - The oozes spit out a projectile, dealing low damage. Cripples."
                ]),
            new GauntletBosses("Deadeye Dunwell", 
                "Deadeye Dunwell deals more damage the further away he is from you. " +
                "Navigate the mines to get to Dunwell quickly.", 
                [
                    "Detonate - Running into a mine will trigger it, dealing massive damage.",
                    "Aimed Shot - A single shot attack.",
                    "Volley - 5 consecutive shots.",
                    "Kill Shot - Dunwell charges for a shot that will deal massive damage.",
                    "Shadowstep - Dunwell will shadowsteps to a random spot in the arena."
                ]),
            new GauntletBosses("Strugar and Chomper",  //Might have to make strugar and chomper seperately.
                "Strugar throws meat for Chomper the rock dog to eat. " +
                "Chomper gets stronger by eating the meat, but you can also eat the meat to get the power yourself. " +
                "Eating too much meat will stun you for a few seconds. " +
                "When Chomper is killed, Strugar will wield caladhog, a giant stick of meat. " +
                "If Strugar dies first Chomper flys into a meaty rage, getting 200% increased damage and movespeed.", 
                [
                    "Scorpion Wire - Strugar pulls you toward them.",
                    "Slash - Chomper claws"
                ]),
            new GauntletBosses("Liadri the Concealing Dark", 
                "", 
                [

                ]),
            new GauntletBosses("Master of Lightning",
                "A Zephyrite that has mastered the aspect of Lightning. Bring stunbreaks or stability.",
                [
                    "Electrical Storm - Lightning cage that knocks you back if you touch the edges",
                    "Electromagnetic Pulse (EMP) - The Master of Lightning channels a large amount of energy, unleashing a large amount of damage and stuns.",
                    "Luminous Hurricane - The Master of Lightning spins around, creating a wind current strong enough to pull you around."
                ]),
            new GauntletBosses("Pallia the Errant",
                "A member of the White Mantle and wields a greatsword. Pallia once sent a warning letter to the commander warning against teaming up with the Shining Blade, signed from \"the Errant\".",
                [
                    "Chaos Orbiter - Pallia summons 6 blue orbs that circle the arena. Avoid them.",
                    "Arcing Slice - Pallia rushes at you and slashes, knocking you down. Bring a stunbreak or stability.",
                    "Sword of Vengeance - Pallia summons a sword in the air that slams down on the ground. You can catch this sword by using your SAK at the right time and then throw it back at Pallia."
                ]),
            new GauntletBosses("Champion Gladiator Waine",
                "Waine wields Caladbolg. When he was a young boy, he fled a battle with it, dooming the sylvari Riannoc. Run circles around Waine to avoid his Sunlit Blades and Split Horizons.",
                [
                    "Sunlit Blades - Waine sends out multiple large projectiles one after the other. Run sideways to avoid them as they deal a ton of damage.",
                    "Split Horizon - Waine splits a line in the ground that stays there for a long time. Don't run into it or you'll get knocked down. Also bleeds",
                    "Mighty Impact - Waine stomps the ground, hitting anyone around him.",
                    "Daybreak Blade - A sword slash.",
                    "Flashing Arc - A sword slash.",
                    "Swift Strike - Wayne dashes to you, finishing with a spinning strike."
                ]),
            new GauntletBosses("Suriel the Radiant Light", 
                "", 
                [

                ]),
            new GauntletBosses("King Turai Ossa", //this might need to be manually done as well
                "A recreation of the legendary former King of Elona. " +
                "Easily the hardest fight of the Gauntlet, Turai Ossa wields his Eternal Blade and the Shield of Elona. " +
                "He also can see through stealth. " +
                "Simply survive until he throws his shield. Bring a lot of blocks and dodges. " +
                "If you avoid the shield throw, his defiance bar will unlock. " +
                "Break the defiance bar and he will continue the fight without the shield. "+
                "If you fail to break the defiance bar, he will regain both his sword and shield. " +
                "After Turai loses both his sword and shield, he resorts to kicks and punches. At this point he's easy to take down.", 
                [
                    "Shield Throw - Turai throws his shield, if you get hit it bounces back and empowers him.",
                    "Shield Bash - ",
                    "Whirlwind Attack - ",
                    "Dragon Slash - ",
                    "Stomp - ",
                    "Savage Leap - Turai leaps toward you with a sword stab.",
                    "Sever Artery - afflicts bleeding.",
                    "Lunging Slash - .",
                    "Power Punch - ",
                    "Jab - ",
                    "Combo - ",
                    "Uppercut - ",
                    "Flying Knee - "
                ])
            ];
    }
}

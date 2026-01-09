namespace ConvergenceCorpBlazor.Classes.Model.Rewards;


public static class RewardsList
{
    private static List<RewardRow> rows = new List<RewardRow>();
    //get the rows of a table.
    public static List<RewardRow> getTableRows(int table) => [.. rows.Where(r => r.Table == table)];
    public static void AddRow(RewardRow r) { rows.Add(r); }



    public static void InitRewards()
    {
        //table 1 -> DAILY from each boss
        //table 2 -> Everytime rewards (even when dailys are done)
        //table 3 -> SotO only rewards
        //table 4 -> JW only rewards
        //table 5 -> VoE only rewards

        /*
         * TABLE 1 DATA -> DAILY from each boss 
         * ID:1-19
         */
        AddRow(new RewardRow(1, 1, "Gold",
            "https://render.guildwars2.com/file/98457F504BA2FAC8457F532C4B30EDC23929ACF9/619316.png",
            "https://wiki.guildwars2.com/wiki/Coin",
            2, 0, 0, 0, "", ""));
        AddRow(new RewardRow(2, 1, "Karma",
            "https://render.guildwars2.com/file/94953FA23D3E0D23559624015DFEA4CFAA07F0E5/155026.png",
            "https://wiki.guildwars2.com/wiki/Karma",
            2000, 0, 0, 0, "", ""));
        AddRow(new RewardRow(3, 1, "Experience",
            "/icons/15px-Experience.png",
            "https://wiki.guildwars2.com/wiki/Experience",
            53340, 64008, 48006, 32004, "", ""));
        AddRow(new RewardRow(4, 1, "Spirit Shard",
            "https://render.guildwars2.com/file/0AD608DE7FDEE0B909905C0AF9401321CF65CD94/1010701.png",
            "https://wiki.guildwars2.com/wiki/Spirit_Shard",
            1, 0, 0, 0, "", ""));
        AddRow(new RewardRow(5, 1, "Convergence Challenge Mode: Gold",
            "https://render.guildwars2.com/file/2D6DA36B3062DD261E4F382664039CCFA8B2C218/1201555.png",
            "https://wiki.guildwars2.com/wiki/Convergence_Challenge_Mode:_Gold",
            0, 1, 0, 0, "", "<20 min"));
        AddRow(new RewardRow(6, 1, "Convergence Challenge Mode: Silver",
            "https://render.guildwars2.com/file/EB06E07FD75BEBF77506A278402AC5B843315F4E/1201556.png",
            "https://wiki.guildwars2.com/wiki/Convergence_Challenge_Mode:_Silver",
            0, 1, 1, 0, "", "<25 min"));
        AddRow(new RewardRow(7, 1, "Convergence Challenge Mode: Bronze",
            "https://render.guildwars2.com/file/E280B3A05B14E5110F17323B282F99974602F2C2/1201554.png",
            "https://wiki.guildwars2.com/wiki/Convergence_Challenge_Mode:_Bronze",
            0, 1, 1, 1, "", "<30 min"));
        AddRow(new RewardRow(8, 1, "Supreme Rune of Holding",
            "https://render.guildwars2.com/file/15474D0D27B9E32F186A153511424A265717BF49/1765996.png",
            "https://wiki.guildwars2.com/wiki/Supreme_Rune_of_Holding",
            5, 0, 0, 0, "", "Rare Chance at 1 to 5"));
        AddRow(new RewardRow(9, 1, "Amalgamated Gemstone",
            "https://render.guildwars2.com/file/35BC2D35511C806348730A5E63152B2E260D4A5C/919363.png",
            "https://wiki.guildwars2.com/wiki/Amalgamated_Gemstone",
            1, 0, 0, 0, "", "Rare Chance at 1"));
        AddRow(new RewardRow(9, 1, "Skyscale Weapon Box",
            "https://render.guildwars2.com/file/657E455192B49F07FC437E42504C3C70D3565D61/1766454.png",
            "https://wiki.guildwars2.com/wiki/Skyscale_Weapon_Box",
            1, 0, 0, 0, "", "Rare Chance at 1"));

        /*
         * TABLE 2 DATA -> Everytime rewards (even when dailys are done)
         * ID: 20-39
         */
        AddRow(new RewardRow(20, 2, "Gold",
            "https://render.guildwars2.com/file/98457F504BA2FAC8457F532C4B30EDC23929ACF9/619316.png",
            "https://wiki.guildwars2.com/wiki/Coin",
            0.5, 0, 0, 0, "5s-17s", ""));
        AddRow(new RewardRow(21, 2, "Karma",
            "https://render.guildwars2.com/file/94953FA23D3E0D23559624015DFEA4CFAA07F0E5/155026.png",
            "https://wiki.guildwars2.com/wiki/Karma",
            1700, 0, 0, 0, "100-400", ""));
        AddRow(new RewardRow(22, 2, "Experience",
            "/icons/15px-Experience.png",
            "https://wiki.guildwars2.com/wiki/Experience",
            77343, 0, 0, 0, "8001-21,336", ""));
        AddRow(new RewardRow(23, 2, "Rift Essence Coffer",
            "https://render.guildwars2.com/file/DC53E3DCA0B1030DD897A0AB0F0B606DCD994451/3187524.png",
            "https://wiki.guildwars2.com/wiki/Rift_Essence_Coffer",
            1, 0, 0, 0, "", "Do not open, it's not worth it! ~7s and 50 essence"));
        AddRow(new RewardRow(24, 2, "Piece of Rare Unidentified Gear",
            "https://render.guildwars2.com/file/EF63A10BD2317CECCEA63A3B7E6555550B414C4E/1766399.png",
            "https://wiki.guildwars2.com/wiki/Piece_of_Rare_Unidentified_Gear",
            2, 0, 0, 0, "", "Chance at being a random exotic instead"));
        AddRow(new RewardRow(25, 2, "Fine Rift Essence",
            "https://render.guildwars2.com/file/41D633F8F0CCFAD7FDADEF7CE84BF7C312AA1B49/3630022.png",
            "https://wiki.guildwars2.com/wiki/Fine_Rift_Essence",
            25, 0, 0, 0, "", "12-25, 25-50 with mastery"));
        AddRow(new RewardRow(26, 2, "Masterwork Rift Essence",
            "https://render.guildwars2.com/file/E0A96441F8405ABEF06114BE750154583CF3B1D2/3630023.png",
            "https://wiki.guildwars2.com/wiki/Masterwork_Rift_Essence",
            10, 0, 0, 0, "", "5-10, 10-20 with mastery"));
        AddRow(new RewardRow(27, 2, "Rare Rift Essence",
            "https://render.guildwars2.com/file/A6012206459C56680D1BD4D23E0B706F0B0AE40D/3630024.png",
            "https://wiki.guildwars2.com/wiki/Rare_Rift_Essence",
            5, 0, 0, 0, "", "2-5, 5-10 with mastery"));
        AddRow(new RewardRow(28, 2, "Rift Essence Extractor",
            "",
            "https://wiki.guildwars2.com/wiki/Rift_Essence_Extractor",
            1, 0, 0, 0, "", "6 hour buff for rift farming"));

        /*
         * TABLE 3 DATA -> SotO only rewards
         * ID:40-59
         */
        AddRow(new RewardRow(40, 3, "Convergence: Hero's Choice Chest",
            "https://render.guildwars2.com/file/46EC231103323FB5EEBBC1AEF74AE015050F013E/3122156.png",
            "https://wiki.guildwars2.com/wiki/Convergence:_Hero%27s_Choice_Chest",
            1, 0, 0, 0, "", "Only 1 per account per day"));
        AddRow(new RewardRow(41, 3, "Piece of Unidentified Gear",
            "https://render.guildwars2.com/file/B147379DFC5430E207FCB742804E199EDF727719/1766400.png",
            "https://wiki.guildwars2.com/wiki/Piece_of_Unidentified_Gear",
            1, 0, 0, 0, "", "Once a day per boss. 1-3 green or higher rarity."));
        AddRow(new RewardRow(42, 3, "Deluxe Gear Box",
            "https://render.guildwars2.com/file/B9BA95E7DEEFF80259C17EB724F7C5E17FB2A1C3/3073209.png",
            "https://wiki.guildwars2.com/wiki/Deluxe_Gear_Box_(Secrets_of_the_Obscure)",
            15, 0, 0, 0, "2-5", "Every Run"));        
        AddRow(new RewardRow(43, 3, "Skyforged Weapon",
            "https://render.guildwars2.com/file/76C965661C0CC3624208EC38C86F3A7B472AAD04/3123407.png",
            "https://wiki.guildwars2.com/wiki/Skyforged_weapons",
            1, 0, 0, 0, "", "Chance once a day per boss. Rare"));
        AddRow(new RewardRow(44, 3, "Abomination Weapon",
            "https://render.guildwars2.com/file/FE09E764EF01150B71EDC5003A0838971132AD5B/3187783.png",
            "https://wiki.guildwars2.com/wiki/Abomination_weapons",
            1, 0, 0, 0, "", "Chance once a day per boss. Exotic"));
        AddRow(new RewardRow(45, 3, "Sinful Weapon",
            "https://render.guildwars2.com/file/D45DCD9ED4089DAF4117EF27ACE462ED20E60872/3122824.png",
            "https://wiki.guildwars2.com/wiki/Sinful_weapons",
            1, 0, 0, 0, "", "Chance once a day per boss. Ascended"));
        AddRow(new RewardRow(46, 3, "Mini Corrupted",
            "https://render.guildwars2.com/file/B0275D0CBB261D01CEF7D71ECA617F6494A896B8/3189306.png",
            "https://wiki.guildwars2.com/wiki/Mini_Corrupted",
            1, 0, 0, 0, "", "Chance every run."));
        AddRow(new RewardRow(47, 3, "Unstable Rift Motivation",
            "https://render.guildwars2.com/file/56573075759450DD5112F1B4C7366AD85470DC2C/3187526.png",
            "https://wiki.guildwars2.com/wiki/Unstable_Rift_Motivation",
            1, 0, 0, 0, "", "1st weekly Convergence."));
        AddRow(new RewardRow(48, 3, "Convergence Extraction",
           "https://render.guildwars2.com/file/46EC231103323FB5EEBBC1AEF74AE015050F013E/3122156.png",
           "https://wiki.guildwars2.com/wiki/Convergence_Extraction",
           1, 0, 0, 0, "", "1 at 2nd weekly Convergence, 2 at 3rd weekly Convergence."));
        AddRow(new RewardRow(49, 3, "Magnificent Convergence Extraction",
           "https://render.guildwars2.com/file/46EC231103323FB5EEBBC1AEF74AE015050F013E/3122156.png",
           "https://wiki.guildwars2.com/wiki/Magnificent_Convergence_Extraction",
           1, 0, 0, 0, "", "Weekly. 1 at 3 unique CM bosses. 1 at 5 unique CM bosses."));

        /*
         * TABLE 4 DATA -> JW only rewards
         * ID:60-79
         */
        AddRow(new RewardRow(60, 4, "Convergence: Mount Balrior Commander's Choice Chest",
            "https://render.guildwars2.com/file/00AABCE916B695E81295E92D2A42ECC37E9039D5/3374827.png",
            "https://wiki.guildwars2.com/wiki/Convergence:_Mount_Balrior_Commander%27s_Choice_Chest",
            1, 0, 0, 0, "", "Only 1 per account per day"));
        AddRow(new RewardRow(61, 4, "Piece of Rare Unidentified Gear",
           "https://render.guildwars2.com/file/EF63A10BD2317CECCEA63A3B7E6555550B414C4E/1766399.png",
           "https://wiki.guildwars2.com/wiki/Piece_of_Rare_Unidentified_Gear",
           3, 0, 0, 0, "", "Once a day per boss"));
        AddRow(new RewardRow(62, 4, "Thimble of Liquid Karma",
           "https://render.guildwars2.com/file/6DF35B17270BF655560BC800BEE03B5BA95BE305/222728.png",
           "https://wiki.guildwars2.com/wiki/Thimble_of_Liquid_Karma",
           2, 0, 0, 0, "", "Once a day per boss"));
        AddRow(new RewardRow(63, 4, "Janthiri Gear Box",
           "https://render.guildwars2.com/file/B76F500FD492F00954A972A6FDC801DBF095D654/3374828.png",
           "https://wiki.guildwars2.com/wiki/Janthiri_Gear_Box",
           20, 0, 0, 0, "2-5", "Every Run"));
        AddRow(new RewardRow(64, 4, "Ursan Ornamented Weapons",
           "https://render.guildwars2.com/file/257AEFE560D2C03D6408542B1033430FB6E2E9E7/3375346.png",
           "https://wiki.guildwars2.com/wiki/Ursan_Ornamented_weapons",
           1, 0, 0, 0, "", "Chance once a day per boss. Rare"));
        AddRow(new RewardRow(65, 4, "Blood Moon Weapons",
           "https://render.guildwars2.com/file/7F2108D17028670F497FCC2C72EFD6256846134E/3442253.png",
           "https://wiki.guildwars2.com/wiki/Blood_Moon_weapons",
           1, 0, 0, 0, "", "Chance once a day per boss. Exotic"));
        AddRow(new RewardRow(66, 4, "Mini Hot Springs Bearkin",
           "https://render.guildwars2.com/file/1F424FFB06FE1FE9AD4BE038BD3E0F0BC1802C10/3441857.png",
           "https://wiki.guildwars2.com/wiki/Mini_Hot_Springs_Bearkin",
           1, 0, 0, 0, "", "Chance once a day per boss. Blue and Yellow"));
        AddRow(new RewardRow(67, 4, "Mini Warclaw Cub",
           "https://render.guildwars2.com/file/99F0D3956B9F454C5492FC0F93FD06DD0B57180F/3441858.png",
           "https://wiki.guildwars2.com/wiki/Mini_Warclaw_Cub",
           1, 0, 0, 0, "", "Chance once a day per boss. Beige, Grey, Orange and White"));
        AddRow(new RewardRow(68, 4, "Mini Grey Journeykin",
           "https://render.guildwars2.com/file/EC501F24DF70E524C604DCBCF0DE5995521250CB/3441859.png",
           "https://wiki.guildwars2.com/wiki/Mini_Grey_Journeykin",
           1, 0, 0, 0, "", "Chance every Run."));
        AddRow(new RewardRow(69, 4, "Unstable Rift Motivation",
            "https://render.guildwars2.com/file/56573075759450DD5112F1B4C7366AD85470DC2C/3187526.png",
            "https://wiki.guildwars2.com/wiki/Unstable_Rift_Motivation",
            1, 0, 0, 0, "", "1st weekly JW Convergence."));
        AddRow(new RewardRow(70, 4, "Convergence Extraction",
           "https://render.guildwars2.com/file/46EC231103323FB5EEBBC1AEF74AE015050F013E/3122156.png",
           "https://wiki.guildwars2.com/wiki/Convergence_Extraction",
           1, 0, 0, 0, "", "1 at 2nd weekly JW Convergence, 2 at 3rd weekly JW Convergence."));
        AddRow(new RewardRow(71, 4, "Magnificent Convergence Extraction",
           "https://render.guildwars2.com/file/46EC231103323FB5EEBBC1AEF74AE015050F013E/3122156.png",
           "https://wiki.guildwars2.com/wiki/Magnificent_Convergence_Extraction",
           1, 0, 0, 0, "", "Weekly. 1 at 3 unique JW CM bosses."));
        /*
         * TABLE 5 DATA -> VoE only rewards
         * ID:80-99
         */

    }
}

namespace ConvergenceCorpBlazor.Classes.Model.Game
{
    public enum GameRegion : byte //8 bits -> 0-255
    {
        None = 0,
        Tyria = 1,      //core
        Maguuma = 2,    //hot
        Desert = 3,     //pof
        Jade = 4,       //eod
        Sky = 5,        //soto
        Wild = 6,       //jw
        Magic = 7       //voe
    }


    public class GameRegionData
    {
        public GameRegion Region; //enum from above
        public String MapName; //convergence map name
        public String Color1;
        public String Color2;

        public GameRegionData(GameRegion region, String mapName, String color1, String color2) {
            this.Region = region;
            this.MapName = mapName;
            this.Color1 = color1;
            this.Color2 = color2;
        }

        public static List<GameRegionData> Data = [
            new GameRegionData(GameRegion.None,"none", "00","00"),
            new GameRegionData(GameRegion.Tyria,"tyriandefense", "00","00"),
            new GameRegionData(GameRegion.Maguuma,"maguumadefense", "00","00"),
            new GameRegionData(GameRegion.Desert,"desertdefense", "00","00"),
            new GameRegionData(GameRegion.Jade,"JadeDefense", "00","00"),
            new GameRegionData(GameRegion.Sky,"Outer Nayos", "#DAA54B","#A28638"),
            new GameRegionData(GameRegion.Wild,"Mount Balrior", "#223073","#53A5C9"),
            new GameRegionData(GameRegion.Magic,"Nexus of Eternity", "#FF713A", "#944798")
            ];
    }
}

namespace ConvergenceCorpBlazor.Classes.TwitchApi.Streamers
{
    public class Streamer
    {
        public string id { get; set; } = "0";
        public string login { get; set; } = "Base Name";
        public string display_name { get; set; } = "Display Name";

        //blank is a normal user. staff - Twitch Staff. global_mod (role removed in 2018). admin - Twitch admininstrator.
        public string type { get; set; } = "";

        //blank is normal user. affiliate and partner are marked here.
        public string broadcaster_type { get; set; } = "";

        public string description { get; set; } = "";
        public string profile_image_url { get; set; } = "";
        public string offline_image_url { get; set; } = "";

        //stream info
        public string game_id { get; set; } = "0";
        public string game_name { get; set; } = "game name";
        public string title { get; set; } = "Stream Title";
        public string[] tags { get; set; } = [];
        public int view_count { get; set; } = 0; //this has been deprecated for years, they haven't removed it from the API yet.
        public string created_at { get; set; } = "";

        
        public string started_at { get; set; } = "2025-07-10T00:00:00Z"; //what time the current stream started
        public int viewer_count { get; set; } = 0; //how many are currently watching!
        public string language { get; set; } = "en";
        public string thumbnail_url { get; set; } = string.Empty;
        public string[] tag_ids { get; set; } = [];
        public bool is_mature { get; set; } = false;


        public DateTimeOffset LastLive { get; set; } = DateTimeOffset.MinValue;
        public bool IsLive { get; set; } = false;

        /*
         * color of the users name in twitch chat, #RRGGBB
         * 
         * Normal users must use a named color listed below.
         * blue, blue_violet, cadet_blue, 
         * chocolate, coral, dodger_blue, 
         * firebrick, golden_rod, green, 
         * hot_pink, orange_red, red, 
         * sea_green, spring_green, yellow_green.
         * 
         * Turbo and Prime can choose any hex code they want.
         */
        public string color { get; set; } = "#"; 

        private static readonly List<string> StreamerNames =
            [
                "sunmatrix",
                "softbreadx",
                "mookchivalry",
                "jmdhouse05",
                "lilyvelour",
                "darenswiths",
                "projektdyad",
                "mcb_bolibear12"
            ];
        public static List<string> GetStreamerNames() {
            return StreamerNames;
        }

        private static List<Streamer> AllStreamers = [];
        
        public static List<Streamer> GetLiveStreamers()
        {
            return AllStreamers.FindAll(s => s.IsLive).OrderBy(s => s.view_count).ToList();
        }
        public static List<Streamer> GetALLStreamers()
        {
            return AllStreamers.OrderByDescending(s => s.LastLive).ThenBy(s => s.display_name).ToList();
        }

        public static void SetALLStreamers(Streamer[] streamers)
        {
            AllStreamers = streamers.ToList();
        }

        public static Streamer? GetStreamer(string id)
        {
            return AllStreamers.FirstOrDefault(s => s.id == id);
        }
    }
}
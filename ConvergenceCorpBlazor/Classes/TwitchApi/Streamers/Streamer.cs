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

        
        public string started_at { get; set; } = "2025-07-10T00:00:00Z";
        public int viewer_count { get; set; } = 0; //how many are currently watching!
        public string language { get; set; } = "en";
        public string thumbnail_url { get; set; } = string.Empty;
        public string[] tag_ids { get; set; } = [];
        public bool is_mature { get; set; } = false;


        public DateTimeOffset LastLive { get; set; } = DateTimeOffset.MinValue;
        public bool IsLive { get; set; } = false;

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
            return AllStreamers.OrderBy(s => s.LastLive).ToList();
        }

        public static void SetALLStreamers(Streamer[] streamers)
        {
            AllStreamers = streamers.ToList();
        }
    }
}
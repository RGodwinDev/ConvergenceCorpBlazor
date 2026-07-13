namespace ConvergenceCorpBlazor.Classes.TwitchApi.Streamers
{
    public class Streams
    {
        public string id { get; set; } = "0"; //the streams ID, use this later to look up vods.
        public string user_id { get; set; } = "0"; //the id of the user
        public string user_login { get; set; } = "default login"; //the users login
        public string user_name { get; set; } = "default Display Name";
        public string game_id { get; set; } = "0"; //ID of the game being streamed
        public string game_name { get; set; } = "default game name"; //name of the game being streamed
        public string type { get; set; } = "live"; //if there's an error, this field is an empty string.
        public string title { get; set; } = "default Stream Title";
        public int viewer_count { get; set; } = 0;
        public string started_at { get; set; } = "";
        public string language { get; set; } = "en";
        public string thumbnail_url { get; set; } = ""; //replace {width}x{height} with the size you want in pixels
        public string[] tag_ids { get; set; } = []; //deprecated, use tags field.
        public string[] tags { get; set; } = [];
        public Boolean is_mature { get; set; } = false;
    }
}

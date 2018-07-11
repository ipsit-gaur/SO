namespace SO.Client.Post
{
    public class PostSM
    {
        public OwnerSM owner { get; set; }
        public int down_vote_count { get; set; }
        public int up_vote_count { get; set; }
        public int score { get; set; }
        public int last_edit_date { get; set; }
        public int last_activity_date { get; set; }
        public int creation_date { get; set; }
        public string post_type { get; set; }
        public int post_id { get; set; }
        public string body { get; set; }
    }

    public class OwnerSM
    {
        public int reputation { get; set; }
        public int user_id { get; set; }
        public string user_type { get; set; }
        public int accept_rate { get; set; }
        public string profile_image { get; set; }
        public string display_name { get; set; }
        public string link { get; set; }
    }
}

using System.Collections.Generic;

namespace SO.Client.Post
{
    public class QuestionSM
    {
        public List<string> tags { get; set; }
        public OwnerSM owner { get; set; }
        public bool is_answered { get; set; }
        public int view_count { get; set; }
        public int favorite_count { get; set; }
        public int down_vote_count { get; set; }
        public int up_vote_count { get; set; }
        public int answer_count { get; set; }
        public int score { get; set; }
        public int last_activity_date { get; set; }
        public int creation_date { get; set; }
        public int last_edit_date { get; set; }
        public int question_id { get; set; }
        public string link { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}

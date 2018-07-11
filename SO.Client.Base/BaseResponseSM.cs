namespace SO.Client.Base
{
    public class BaseResponseSM
    {
        public bool has_more { get; set; }
        public int backoff { get; set; }
        public int quota_max { get; set; }
        public int quota_remaining { get; set; }
    }
}

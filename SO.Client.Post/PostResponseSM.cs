using SO.Client.Base;
using System.Collections.Generic;

namespace SO.Client.Post
{
    public class PostResponseSM : BaseResponseSM
    {
        public List<PostSM> items { get; set; }
    }
}

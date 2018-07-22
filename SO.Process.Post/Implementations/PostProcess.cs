using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SO.Client.Post;
using SO.Process.Base;

namespace SO.Process.Post
{
    public class PostProcess : BaseProcess, IPostProcess
    {
        private readonly PostClient _client;

        public PostProcess(PostClient client)
        {
            _client = client;
        }

        public async Task<List<Models.Post>> GetRecentPosts()
        {
            var postsResponse = await _client.GetPosts();
            if (postsResponse.items != null)
            {
                return MapPosts(postsResponse.items);
            }
            return null;
        }

        private List<Models.Post> MapPosts(List<PostSM> items)
        {
            return items.Select(x => new Models.Post
            {
                ID = x.post_id,
                Body = x.body
            }).ToList();
        }
    }
}

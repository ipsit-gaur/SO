using System.Collections.Generic;
using System.Threading.Tasks;

namespace SO.Process.Post
{
    public interface IPostProcess
    {
        Task<List<Models.Post>> GetRecentPosts();
    }
}

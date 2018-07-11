using SO.Client.Base;
using System.Net.Http;
using System.Threading.Tasks;

namespace SO.Client.Post
{
    public class PostClient: BaseClient
    {
        public async Task<PostResponseSM> GetPosts()
        {
            return await base.GetResponse<PostResponseSM, object>("/2.2/posts?order=desc&sort=activity&site=stackoverflow", HttpMethod.Get, null, false);
        }

        public async Task<QuestionResponseSM> GetUnAnsweredQuestions()
        {
            return await base.GetResponse<QuestionResponseSM, object>("/2.2/questions/unanswered?order=desc&sort=creation&site=stackoverflow", HttpMethod.Get, null, false);
        }
    }
}

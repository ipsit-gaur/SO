using Microsoft.AspNetCore.Mvc;
using SO.Client.Post;
using SO.Process.Post;
using SOWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Questions")]
    public class QuestionsController : Controller
    {
        private readonly PostClient _postClient;
        private readonly IPostProcess _postProcess;

        public QuestionsController()
        {
            _postClient = new PostClient();
            _postProcess = new PostProcess(_postClient);
        }

        public async Task<IEnumerable<QuestionVM>> GetQuestions()
        {
            var questions = await _postProcess.GetRecentPosts();
            Random random = new Random();
            return questions.Select((x) => new QuestionVM
            {
                Answers = random.Next(10),
                Author = "New",
                Description = x.Body,
                Id = x.ID,
                Tags = new List<string>(),
                TimeAsked = "3 mins ago",
                Views = random.Next(10),
                Votes = random.Next(10)
            });
        }
    }
}
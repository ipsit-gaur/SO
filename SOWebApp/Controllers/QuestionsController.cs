using Microsoft.AspNetCore.Mvc;
using SOWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Questions")]
    public class QuestionsController : Controller
    {
        public IEnumerable<QuestionVM> GetQuestions()
        {
            Random random = new Random();
            return Enumerable.Range(1, 5).Select((index) => new QuestionVM
            {
                Answers = random.Next(10),
                Author = "New",
                Description = "This is test question shown to the user, can you answer this?",
                Id = index,
                Tags = new List<string>(),
                TimeAsked = "3 mins ago",
                Views = random.Next(10),
                Votes = random.Next(10)
            });
        }
    }
}
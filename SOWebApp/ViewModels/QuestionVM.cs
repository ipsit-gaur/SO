using System.Collections.Generic;

namespace SOWebApp.ViewModels
{
    public class QuestionVM
    {
        public int Votes { get; set; }
        public int Answers { get; set; }
        public int Views { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string TimeAsked { get; set; }
        public int Id { get; set; }
        public string Author { get; set; }
    }
}

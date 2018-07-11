using SO.Client.Post;
using System.Windows.Controls;

namespace StackOverflow.Views
{
    /// <summary>
    /// Interaction logic for QuestionsFeed.xaml
    /// </summary>
    public partial class QuestionsFeed : Page
    {
        public QuestionsFeed()
        {
            InitializeComponent();

            var postClient = new PostClient();
            var questions = postClient.GetUnAnsweredQuestions().Result;
        }
    }
}

using SO.Client.Post;
using StackOverflow.Utils;
using System.Threading.Tasks;
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
            var questionsTask = new NotifyTaskCompletion<QuestionResponseSM>(postClient.GetUnAnsweredQuestions());
        }
    }
}

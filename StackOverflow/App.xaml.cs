using StackOverflow.ViewModel;
using System.Windows;

namespace StackOverflow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var viewmodelLocator = new ViewModelLocator();
        }
    }
}

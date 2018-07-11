using GalaSoft.MvvmLight.Ioc;
using StackOverflow.ViewModel;
using System.Windows.Controls;

namespace StackOverflow.Controls
{
    /// <summary>
    /// Interaction logic for Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();

            DataContext = SimpleIoc.Default.GetInstance<HeaderVM>();
        }
    }
}

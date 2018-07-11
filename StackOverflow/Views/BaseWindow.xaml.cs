using System;
using System.Windows;

namespace StackOverflow.Views
{
    /// <summary>
    /// Interaction logic for BaseWindow.xaml
    /// </summary>
    public partial class BaseWindow : Window
    {
        public BaseWindow()
        {
            InitializeComponent();

            ContentFrame.Source = new Uri("QuestionsFeed.xaml", UriKind.Relative);
        }
    }
}

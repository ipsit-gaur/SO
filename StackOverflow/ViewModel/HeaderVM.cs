using GalaSoft.MvvmLight;
using System;
using System.Windows.Media.Imaging;

namespace StackOverflow.ViewModel
{
    public class HeaderVM : ViewModelBase
    {
        private BitmapImage _logoImage;

        public BitmapImage LogoPath
        {
            get => _logoImage;
            set
            {
                _logoImage = value;
                RaisePropertyChanged(nameof(LogoPath));
            }
        }

        public HeaderVM()
        {
            LogoPath = new BitmapImage(new Uri("pack://application:,,,/Images/so-logo.png"));
        }
    }
}

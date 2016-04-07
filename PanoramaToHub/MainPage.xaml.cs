using Windows.UI.Xaml.Controls;

namespace PanoramaToHub
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = new MainViewModel();
        }
    }
}

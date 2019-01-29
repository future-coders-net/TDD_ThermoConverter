using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TDD_ThermoConverter
{
    public sealed partial class MainPage : Page
    {
        ViewModel viewModel = new ViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = viewModel;
            Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
        }
        private void CoreWindow_KeyDown(Windows.UI.Core.CoreWindow sender,
            Windows.UI.Core.KeyEventArgs args)
        {
            viewModel.KeyDown(args.VirtualKey);
        }

    }
}

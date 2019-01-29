using Windows.UI.Xaml.Controls;

namespace TDD_ThermoConverter
{
    public sealed partial class MainPage : Page
    {
        TemperatureModel model;

        public MainPage()
        {
            this.InitializeComponent();
            model = new TemperatureModel();
            DataContext = model;
        }
    }
}

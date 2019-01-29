using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace TDD_ThermoConverter
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Slider_ValueChanged(object sender,
            RangeBaseValueChangedEventArgs e)
        {
            Celsius.Text = e.NewValue.ToString();
            Fahrenheit.Text = (e.NewValue * 1.8 + 32).ToString();
        }
    }
}

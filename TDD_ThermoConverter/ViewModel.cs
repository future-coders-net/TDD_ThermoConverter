namespace TDD_ThermoConverter
{
    class ViewModel
    {
        private TemperatureModel model;

        public ViewModel()
        {
            model = new TemperatureModel();
        }

        public TemperatureModel TemperatureModel
        {
            get { return model; }
        }

        public void KeyDown(Windows.System.VirtualKey key)
        {
            if (key == Windows.System.VirtualKey.U)
            {
                model.Celsius += 10;
            }
            if (key == Windows.System.VirtualKey.D)
            {
                model.Celsius -= 10;
            }
        }
    }
}

namespace DelegateLearning.EventConsole
{
    /// <summary>
    /// Güvenli ve kontrollü erişim
    /// </summary>
    internal class TemperatureSensorEventBased
    {
        // Sadece bu sınıf içerisinden tetiklenebilecek bir event tanımlıyoruz
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        private int _currentTemperature;

        public int CurrentTemperature
        {
            get => _currentTemperature;
            set
            {
                if (_currentTemperature != value)
                {
                    _currentTemperature = value;
                    OnTemperatureChanged(value);
                }
            }
        }

        protected virtual void OnTemperatureChanged(int newTemperature)
        {
            TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(newTemperature));
        }
    }
}

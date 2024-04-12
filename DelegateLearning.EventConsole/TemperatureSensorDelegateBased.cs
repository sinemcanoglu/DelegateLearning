namespace DelegateLearning.EventConsole
{
    /// <summary>
    /// Daha az kısıtlayıcı,ancak kötüye kullanıma açıktır
    /// </summary>
    internal class TemperatureSensorDelegateBased
    {
        public delegate void TemperatureChangeHandler(object sender, TemperatureChangedEventArgs args);
        public TemperatureChangeHandler TemperatureChanged;
            
    }
}

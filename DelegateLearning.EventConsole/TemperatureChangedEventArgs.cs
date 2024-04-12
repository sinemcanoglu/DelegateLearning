namespace DelegateLearning.EventConsole
{
    internal class TemperatureChangedEventArgs(int temperature) : EventArgs
    {
        public int Temperature { get; } = temperature;
    }
}

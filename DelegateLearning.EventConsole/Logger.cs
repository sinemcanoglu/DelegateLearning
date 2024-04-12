namespace DelegateLearning.EventConsole
{
    internal class Logger
    {
        public void LogTemperature(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"Temperature logged at: {e.Temperature} degrees.");
        }
    }
}

namespace DelegateLearning.EventConsole
{
    internal class AlarmSystem
    {
        public void ActivateAlarm(object sender, TemperatureChangedEventArgs e)
        {
            if (e.Temperature > 100)
            {
                Console.WriteLine($"Alarm activated! Current temperature is {e.Temperature} degrees, which is too high!");
            }
        }
    }
}

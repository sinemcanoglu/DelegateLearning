namespace DelegateLearning.BasicConsole
{
    internal class EventDelegate
    {
        public event EventHandler? OnSessionEnd;

        public void Execute()
        {
            OnSessionEnd?.Invoke(this, EventArgs.Empty);
        }

        public EventDelegate()
        {
            OnSessionEnd += HandleSessionEnd;
        }

        private void HandleSessionEnd(object? sender, EventArgs e)
        {
            Console.WriteLine("This session has now ended. Thank you for your participation!");
        }
    }
}

namespace DelegateLearning.BasicConsole
{
    internal class BasicDelegate
    {
        delegate void WelcomeSpeech();

        public void Execute()
        {
            WelcomeSpeech speech = Welcome;
            speech();
        }

        private void Welcome()
        {
            Console.WriteLine("Welcome to our Annual Conference!");
        }
    }
}

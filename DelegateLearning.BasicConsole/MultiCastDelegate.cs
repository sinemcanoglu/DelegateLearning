namespace DelegateLearning.BasicConsole
{
    internal class MultiCastDelegate
    {
        delegate void ClosingSpeech();

        public void Execute()
        {
            ClosingSpeech del = Thank;
            del += WrapUp;
            del();
        }

        private void Thank()
        {
            Console.WriteLine("Thank you all for coming!");
        }

        private void WrapUp()
        {
            Console.WriteLine("Please leave your feedback before you leave.");
        }
    }
}

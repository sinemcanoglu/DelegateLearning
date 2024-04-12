namespace DelegateLearning.BasicConsole
{
    internal class GenericDelegate<T>
    {
        delegate void FeedbackDelegate(T feedback);

        public void Execute(T feedback)
        {
            FeedbackDelegate del = Feedback;
            del(feedback);
        }

        private void Feedback(T feedback)
        {
            Console.WriteLine(feedback);
        }
    }
}

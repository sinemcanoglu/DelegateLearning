namespace DelegateLearning.BasicConsole
{
    internal class ReturnDelegate
    {
        delegate bool AnswerDelegate(string question, bool correct);

        public bool Execute(string question, bool correct)
        {
            AnswerDelegate del = Answer;
            return del(question, correct);
        }

        private bool Answer(string question, bool correct)
        {
            Console.WriteLine($"Question: {question}");
            return correct;
        }
    }
}

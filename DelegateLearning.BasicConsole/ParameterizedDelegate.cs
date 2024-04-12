namespace DelegateLearning.BasicConsole
{
    internal class ParameterizedDelegate
    {
        delegate void InformDelegate(string message);

        public void Execute(string info)
        {
            InformDelegate del = Inform;
            del(info);
        }

        private void Inform(string message)
        {
            Console.WriteLine(message);
        }
    }
}

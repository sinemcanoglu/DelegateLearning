using DelegateLearning.BasicConsole;

BasicDelegate opening = new();
ParameterizedDelegate speaker = new();
ReturnDelegate panel = new();
MultiCastDelegate closing = new();
EventDelegate session = new();

opening.Execute();
speaker.Execute("Welcome to our special session on Delegates!");
bool answer = panel.Execute("Is delegate a type-safe function pointer?", true);
Console.WriteLine($"Answer: {answer}");
closing.Execute();
session.Execute();

GenericDelegate<string> feedback = new();
feedback.Execute("Thank you for attending!");
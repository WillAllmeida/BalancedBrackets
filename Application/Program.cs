using Application.Helpers;

var argument = Environment.GetCommandLineArgs();

Console.WriteLine("Insira uma string:");

var input = argument.Length > 1 ? argument[1] : Console.ReadLine();

if (input is null)
{
    Console.WriteLine("Dados inseridos não são válidos");
    return;
}

Console.WriteLine(BracketHelper.IsBalanced(input!) ? "Válida" : "Inválida");
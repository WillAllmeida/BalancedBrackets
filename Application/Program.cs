using Application.Helpers;

Console.WriteLine("Insira uma string:");

var input = args.Length > 0 ? args[0] : Console.ReadLine();

if (input is null)
{
    Console.WriteLine("Dados inseridos não são válidos");
    return;
}

Console.WriteLine(BracketHelper.IsBalanced(input!) ? "Válida" : "Inválida");
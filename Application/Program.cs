using Application.Helpers;

var input = Console.ReadLine();

if(input is null)
{
    Console.WriteLine("Dados inseridos não são válidos");
    return;
}

Console.WriteLine(BracketHelper.IsBalanced(input!) ? "Válida" : "Inválida");
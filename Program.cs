Console.WriteLine("--- Milhas para KM ---");
Console.Write("Informe o valor em milhas: ");
//1 - Declarando a string, atribuindo e convertendo o double
string entrada = Console.ReadLine()!;
double milhas = Convert.ToDouble(entrada);

//2 - Declarando e convertendo diretamente o double (opção ao 1)
//double _milhas + Convert.ToDouble(Console.ReadLine()!);

double resultado = milhas * 1.609;

Console.WriteLine($"{milhas} milhas em km --> {resultado}");
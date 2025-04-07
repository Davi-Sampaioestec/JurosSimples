Console.Clear();


Console.Write("Insira o total de capital 💰 : ");
double	capital =  Convert.ToDouble (Console.ReadLine());

Console.Write("Insira o percentual da taxa de juros % : ");
double taxaDeJuros = Convert.ToDouble (Console.ReadLine());
double taxaDeJuros2 = taxaDeJuros /100;

Console.Write("Insira o tempo em meses ⏳ : ");
double tempo = Convert.ToDouble (Console.ReadLine());

double juros = capital * taxaDeJuros2 * tempo;

double montante = capital + juros;

Console.WriteLine($"Montante {montante:C}");

Console.WriteLine($"Juros {juros:C}");

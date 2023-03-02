int baseT;
Console.WriteLine("Para calcular a área do triângulo, por favor, insira o valor da base:");
 baseT = int.Parse(Console.ReadLine());

int heightT;
Console.WriteLine("Para continuar, insira o valor da altura do triângulo:");
heightT = int.Parse(Console.ReadLine());

int area = baseT * heightT;
int result = area / 2;

Console.WriteLine($"A área do triângulo é: {result}");

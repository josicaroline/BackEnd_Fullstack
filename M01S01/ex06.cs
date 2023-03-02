Console.WriteLine("Exibindo a tabuada!");

int number;
Console.WriteLine("Digite o número abaixo:");
number = int.Parse(Console.ReadLine());


for (int count = 0; count <= 10; count++) {
    int result = number * count;
    Console.WriteLine(result);
}
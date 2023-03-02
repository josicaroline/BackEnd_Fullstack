string name;
Console.WriteLine("Olá, Tudo Bem? Qual o seu nome?");
name = Console.ReadLine();

string lastName;
Console.WriteLine("Qual o seu sobrenome?");
lastName = Console.ReadLine();

int age;
Console.WriteLine("Qual a sua idade?");
age = int.Parse(Console.ReadLine());

string color;
Console.WriteLine("Qual sua cor favorita?");
color = Console.ReadLine();

Console.WriteLine($"Nome: {name}");
Console.WriteLine($"Sobrenome: {lastName}");
Console.WriteLine($"Idade: {age}");
Console.WriteLine($"Cor favorita: {color}");

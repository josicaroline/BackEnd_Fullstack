decimal grade1;
Console.WriteLine("Digite a nota 1:");
grade1 = decimal.Parse(Console.ReadLine());

decimal grade2;
Console.WriteLine("Digite a nota 2:");
grade2 = decimal.Parse(Console.ReadLine());

decimal grade3;
Console.WriteLine("Digite a nota 3:");
grade3 = decimal.Parse(Console.ReadLine());

decimal average = ((grade1 + grade2 + grade3) / 3);

if (average >= 6) {
    Console.WriteLine($"Aluno aprovado com média {average}");
} 
else if (average >= 5) {
    Console.WriteLine($"Aluno em recuperação com média {average}");
}
else {
    Console.WriteLine($"Aluno reprovado com média {average}");
}
Console.WriteLine("Olá, siga os passos abaixo para criar o boletim dos alunos!");

//student name variable
string name;
Console.WriteLine("Qual o nome do aluno?");
name = Console.ReadLine();

//array size variable
int sizeArray;
Console.WriteLine("Quantas notas terá este boletim?");
sizeArray = int.Parse(Console.ReadLine());

decimal[] grades = new decimal [sizeArray];

for (int i = 0; i < sizeArray; i++) {
    Console.WriteLine("Digite a " + (i+1) + " nota:");
    grades[i] = decimal.Parse(Console.ReadLine());
}

//average calculation
decimal total = 0;

for (int count = 0; count < sizeArray; count++) {
    total = total + grades[count];
}

//output
Console.WriteLine($"Aluno: {name}");

for (int i = 0; i < sizeArray; i++) {
    Console.WriteLine("Nota " + (i+1) + ": " + grades[i]);
}

// average correlation with approval
decimal average = (total / sizeArray);

if (average >= 6) {
    Console.WriteLine($"Aluno aprovado com média {average}");
} 
else if (average >= 5) {
    Console.WriteLine($"Aluno em recuperação com média {average}");
}
else {
    Console.WriteLine($"Aluno reprovado com média {average}");
}
decimal payment;
Console.WriteLine("Digite o valor do seu salário:");
payment = decimal.Parse(Console.ReadLine());

decimal taxValue;

if (payment <= 900) {
    Console.WriteLine("Não descontou no salário");
}
else if (payment <= 1500) {
    taxValue = ((payment / 100) * 5);
    Console.WriteLine($"o desconto será de 5%, de acordo com a tabela, portanto o valor de imposto devido será de R${taxValue}.");
}
else if (payment <= 2500) {
 taxValue = ((payment / 100) * 10);
 Console.WriteLine($"O desconto será de 10%, de acordo com a tabela, portanto o valor de imposto devido será de R${taxValue}.");
}
else {
    taxValue = ((payment / 100) * 20);
    Console.WriteLine($"o desconto será de 20%, de acordo com a tabela, portanto o valor de imposto devido será de R${taxValue}.");
}

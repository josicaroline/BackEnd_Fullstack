Console.WriteLine("Olá, para descobrir o tipo de seu triângulo digite as informações na sequência!");

float side1;
Console.WriteLine("Digite o valor do lado 1 de seu triângulo:");
side1 = float.Parse(Console.ReadLine());

float side2;
Console.WriteLine("Digite o valor do lado 2 de seu triângulo:");
side2 = float.Parse(Console.ReadLine());

float side3;
Console.WriteLine("Digite o valor do lado 3 de seu triângulo:");
side3 = float.Parse(Console.ReadLine());

if (side1 + side2 > side3 || side1 + side3 > side2 || side2 + side3 > side1) {
    Console.WriteLine("Os lados formam um triângulo");
    }
    else { 
        Console.WriteLine("Os lados não formam um triângulo");
    }
      

if (side1 == side2 && side2 == side3 && side1 == side3) {
        Console.WriteLine("As medidas formam um triângulo equilátero");
    }
    else if (side1 == side2 || side2 == side3 || side1 == side3) {
         Console.WriteLine("As medidas formam um triângulo isósceles");
    }
    else if (side1 != side2 && side2 != side3 && side1 != side3) {
        Console.WriteLine("As medidas formam um triângulo escaleno");
    }
    else {
        Console.WriteLine("Os lados não formam um triângulo");
    }
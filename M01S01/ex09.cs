List<double> transactions = new List<double>();
string option;

//welcome menu
do {
    Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor selecione uma opção para continuar:");
    Console.WriteLine("1. Adicionar transação;");
    Console.WriteLine("2. Consultar extrato;");
    Console.WriteLine("3. Sair;");
    option = Console.ReadLine();
    
//selected options
//display the balance of the entire transaction list
    if (option == "1") {
        Console.WriteLine("Digite o valor da transação (R$): ");
        double value = double.Parse(Console.ReadLine());
        transactions.Add(value);
    }
    else if (option == "2") {
        Console.WriteLine ("Seu extrato (R$): ");
        double balance = 0;
        foreach(var value in transactions){
            balance = balance + value;
            Console.WriteLine($"R$ {value}");
        }
        Console.WriteLine($"Seu saldo (R$) {balance}");
    }
    } while (!(option == "3"));

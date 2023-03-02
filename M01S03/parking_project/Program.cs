﻿
using parking_project;

List<Carro> carros = new List<Carro>();

string opcao;

do{
    Console.WriteLine("Olá, seja bem vindo ao estacionamento Pare Aqui, selecione a opção desejada:");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Marcar Entrada");
    Console.WriteLine("3 - Marcar Saída");
    Console.WriteLine("4 - Consultar Histórico");
    Console.WriteLine("5 - Sair");
    opcao = Console.ReadLine();

    if (opcao == "1") 
    {
        CadastrarCarro();
    }

    if (opcao == "2") 
    {
        GerarTicket();
    }

    if (opcao == "3")
    {
        FecharTicket();
    }

    if (opcao == "4")
    {
        Historico();
    }

}while (opcao != "5");

void CadastrarCarro() 
{
    Carro carro = new Carro();
    Console.WriteLine("Digite a placa do carro:");
    carro.Placa = Console.ReadLine();
    Console.WriteLine("Digite o modelo do carro:");
    carro.Modelo = Console.ReadLine();
    Console.WriteLine("Digite a cor do carro:");
    carro.Cor = Console.ReadLine();
    Console.WriteLine("Digite a marca do carro:");
    carro.Marca = Console.ReadLine();
    carros.Add(carro);
}

Carro ObterCarro(string placa)
{
    foreach (var carro in carros)
    {
        if (placa == carro.Placa)
        {
            return carro;
        }
    }
    return null;
}

void GerarTicket()
{
    Console.WriteLine("Qual a placa do carro?");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);
    if (carro == null)
    {
        Console.WriteLine("Carro não cadastrado!");
        return;
    }

    foreach (var ticket in carro.Tickets)
    {
        if (ticket.Ativo == true)
        {
            Console.WriteLine("Carro já esta no estacionamento!");
            return;
        }
    }

    Ticket ticketNovo = new Ticket();
    carro.Tickets.Add(ticketNovo);
    Console.WriteLine("Ticket gerado!");
}

void FecharTicket()
{
    Console.WriteLine("Qual a placa do carro?");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);
    if (carro == null)
    {
        Console.WriteLine("Carro não cadastrado!");
        return;
    }

    Ticket ticketAberto = null;
    foreach (var ticket in carro.Tickets)
    {
        if (ticket.Ativo == true)
        {
            ticketAberto = ticket;
        }
    }
    if (ticketAberto == null) 
    {
        Console.WriteLine("Não há tickets em aberto para o carro!");
        return;
    }

    ticketAberto.FecharTicket();
}

void Historico()
{
    Console.WriteLine("Qual a placa do carro?");
    string placa = Console.ReadLine();

    var carro = ObterCarro(placa);
    if (carro == null)
    {
        Console.WriteLine("Carro não cadastrado!");
        return;
    }

    Console.WriteLine("Entrada              |Saída              |Ativo           |Valor             ");

    foreach (var ticket in carro.Tickets)
    {
        if (ticket.Ativo == true)
        {
            Console.WriteLine($"{ticket.Entrada}          |--------------------- |{ticket.Ativo.ToString()}         |R$--,-- ");
        }
        else 
        {
        Console.WriteLine($"{ticket.Entrada}          |{ticket.Saida}          |{ticket.Ativo.ToString()}         |R${ticket.CalcularValor()}");
        }
    }
}

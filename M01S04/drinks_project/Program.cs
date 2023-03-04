
using drinks_project;

bool showMenu = true;

while (showMenu)
{
    Menu.Displayinicial();
    var opcao = Menu.SelecionarOpcao();

    Bebida bebida = InstanciarBebida();
    if (bebida == null) {
        break;
    }

    switch (opcao)
    {
        case 1:
            Repositorio.AdicionarBebida(bebida);
            showMenu = Menu.ReiniciarDisplayConsole();
            break;
        case 2:
            Repositorio.AlterarBebida(bebida);
            showMenu = Menu.ReiniciarDisplayConsole();
            break;
        case 3: 
            Repositorio.ExcluirBebida(bebida.Id);
            showMenu = Menu.ReiniciarDisplayConsole();
            break;
        case 4: 
            Repositorio.ListarBebida();
            showMenu = Menu.ReiniciarDisplayConsole();
            break;
        case 5:
            Repositorio.ListarSuco();
            break;
        case 6: 
            Repositorio.ListarRefrigerante();
            break;
        case 7:
            Console.WriteLine("Obridada, até a próxima!!");
            showMenu = false;
            break;
        default: 
            Console.WriteLine("Dados com erros, aguarde 5 milisegundos para a tela carregar display inicial");
            Thread.Sleep(5000);
            Menu.Displayinicial();
            break;
    }
}


Bebida InstanciarBebida()
{
    Console.WriteLine("Qual o tipo de bebida?");
    string tipo = Console.ReadLine();
    Console.WriteLine("Qual o id?");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("quantos mililitros possui?");
    decimal miliLitro = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Qual o nome da bebida?");
    string nomeBebida = Console.ReadLine();
    Console.WriteLine("Qual o valor de compra?");
    decimal valorCompra = decimal.Parse(Console.ReadLine());

     if (tipo == "Suco") 
     {
        Console.WriteLine("tipo caixa?");
        string tipoCaixa = Console.ReadLine();
        return new Suco(tipoCaixa, id, tipo, miliLitro, nomeBebida, valorCompra);
     }
     else if (tipo == "Refrigerante")
     {
        Console.WriteLine("é vidro?");
        bool vidro = bool.Parse(Console.ReadLine());
        return new Refrigerante(vidro, id, tipo, miliLitro, nomeBebida, valorCompra);
     }
     else
     {
        Console.WriteLine("Opção não encontrada");
        return null;
     }
}

Bebida bebida1 = InstanciarBebida();
bebida1.Comprar();

Suco suco1 = new Suco("caixa", 1, "suco", 200, "maguary", 7);
Refrigerante refrigerante1 = new Refrigerante(false, 2, "refrigerante", 300, "fanta", 8);

Repositorio.AdicionarRefrigerante(refrigerante1);
Repositorio.AdicionarSuco(suco1);

var listaAntesExcluir = Repositorio.ListarBebida();
Repositorio.ExcluirBebida(1);
var listaAposExcluir = Repositorio.ListarBebida();

Repositorio.ImprimirRefrigerante();
Repositorio.ImprimirRefrigerante();

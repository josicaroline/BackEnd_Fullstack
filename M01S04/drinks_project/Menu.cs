using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drinks_project
{
    public static class Menu
    {
        public static void Displayinicial()
        {
            Console.Clear();
            Console.WriteLine("\n"); 
            Console.WriteLine("Menu de bebidas:");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\n"); 
        }

         public static int SelecionarOpcao()
        {
            try
            {
            Console.WriteLine("Selecione a opção desejada: ");

            Console.WriteLine("1 - Inserir bebida.");
            Console.WriteLine("2 - Alterar bebida.");
            Console.WriteLine("3 - Excluir bebida.");
            Console.WriteLine("4 - Listar todas as bebidas.");
            Console.WriteLine("5 - Listar todos os sucos.");
            Console.WriteLine("6 - Listar todos os refrigerantes.");
            Console.WriteLine("7 - Sair do menu.");
            Console.WriteLine("\n");

            Console.WriteLine("Opção: ");
            return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Opção com erro, selecione a correta!");
            }
            
            return SelecionarOpcao();
        }

        public static bool ReiniciarDisplayConsole()
        {
            try
            {
                Console.WriteLine("\n");    
                Console.WriteLine("Deseja reiniciar o menu?");    
                Console.WriteLine("----------------------------------------------");   
                Console.WriteLine("1 - Sim.");
                Console.WriteLine("2 - Não.");            
                Console.WriteLine("\n");

                if (Convert.ToInt32(Console.ReadLine()) == 1)
                {
                    Menu.Displayinicial();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Opção com erro, selecione a correta!");
            }
            
            return ReiniciarDisplayConsole();
        }
    }
}

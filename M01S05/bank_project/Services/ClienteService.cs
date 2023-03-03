using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using M1S3_SistemaBanco.Model;
using M1S3_SistemaBanco.Interface;

namespace M1S3_SistemaBanco.Services
{
    public class ClienteService : IClienteService
    {
        static List<Cliente> clientes = new List<Cliente>();

        public void CriarConta()
        {
            string opcao1;

             do{
                Console.WriteLine("Escolha uma opção para criar conta:");
                Console.WriteLine("1 - Criar Conta Pessoa Física");
                Console.WriteLine("2 - Criar Conta Pessoa Jurídica");
                Console.WriteLine("3 - Sair");
                opcao1 = Console.ReadLine();

                if(opcao1 == "1")
                {
                    PessoaFisica aux = this.CriarContaPessoaFisica();

                    if (aux != null) {
                      clientes.Add(aux);  
                    }
                }
                else if (opcao1 == "2")
                {
                  PessoaJuridica aux1 = this.CriarContaPessoaJuridica();
                   
                   if (aux1 != null) {
                     clientes.Add(aux1);
                   }
                }
             } while(opcao1 != "3");
        }


        public Cliente BuscarClientePorNumeroDeConta(int numeroConta)
        {
            foreach(Cliente cliente in clientes)
            {
              if(cliente.NumeroConta == numeroConta)
              {
                return cliente;
              }
            }
            return null;
        }

        public void ExibirClientes()
        {
          Console.WriteLine("Número da conta        | Nome         | CPF    ");
          for(int i =0; i < clientes.Count; i++)
          {
            clientes[i].ResumoCliente();
          }
        }

        private PessoaFisica CriarContaPessoaFisica()
        {
          PessoaFisica pessoafisica = new PessoaFisica();
          Console.WriteLine("Data de Nascimento do cliente:");
          pessoafisica.DataNascimento = DateTime.Parse(Console.ReadLine());
          if(!pessoafisica.EhMaior())
          {
            Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
            return null;
          }

            Console.WriteLine("A idade do cliente é " + pessoafisica.Idade);
            Console.WriteLine("Nome do cliente:");
            pessoafisica.Nome = Console.ReadLine();
            Console.WriteLine("CPF do cliente:");
            pessoafisica.CPF = Console.ReadLine();
            Console.WriteLine("Endereco do cliente:");
            pessoafisica.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone do cliente:");
            pessoafisica.Telefone = Console.ReadLine();
            Console.WriteLine("Email do cliente:");
            pessoafisica.Email = Console.ReadLine();
            Console.WriteLine("Tipo de conta?");
            pessoafisica.TipoConta = Console.ReadLine();            
            Console.WriteLine("Numero Da Conta");
            pessoafisica.NumeroConta = int.Parse(Console.ReadLine());
            return pessoafisica;
        }

        private PessoaJuridica CriarContaPessoaJuridica()
        {
          PessoaJuridica pessoajuridica = new PessoaJuridica();
          Console.WriteLine("Razão social:");
          pessoajuridica.RazaoSocial = Console.ReadLine();
          Console.WriteLine("CNPJ:");
          pessoajuridica.CNPJ = Console.ReadLine();
          Console.WriteLine("Endereco do cliente:");
          pessoajuridica.Endereco = Console.ReadLine();
          Console.WriteLine("Telefone do cliente:");
          pessoajuridica.Telefone = Console.ReadLine();
          Console.WriteLine("Email do cliente:");
          pessoajuridica.Email = Console.ReadLine();
          Console.WriteLine("Tipo de conta?");
          pessoajuridica.TipoConta = Console.ReadLine();          
          Console.WriteLine("Numero Da Conta");
          pessoajuridica.NumeroConta = int.Parse(Console.ReadLine());
          return pessoajuridica;
        }
    }
}
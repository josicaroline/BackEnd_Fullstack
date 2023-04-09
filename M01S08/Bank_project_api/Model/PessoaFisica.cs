using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco.Model
{
    public class PessoaFisica : Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get {return (int)(Math.Floor((DateTime.Now - DataNascimento).TotalDays / 365.25)); } private set {} }

        public PessoaFisica (string nome, string cpf, DateTime dataNascimento, int idade, int numeroConta, string tipoConta, string email, string telefone, string end) : base (numeroConta, tipoConta, email, telefone, end)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.DataNascimento = dataNascimento;
            this.Idade = idade;
        }

        public PessoaFisica()
        {
            
        }

        public bool EhMaior()
        {
            return Idade >= 18;
        }

        public override void ResumoCliente()
        {
            base.ResumoCliente();
            Console.WriteLine($"{NumeroConta} | {Nome} | {CPF}");
        }
    }
}
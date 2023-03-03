using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S3_SistemaBanco.Model
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public PessoaJuridica (string razaoSocial, string cnpj, int numeroConta, string tipoConta, string email, string telefone, string end) : base (numeroConta, tipoConta, email, telefone, end)
        {
            this.RazaoSocial = razaoSocial;
            this.CNPJ = cnpj;
        }

        public PessoaJuridica()
        {
            
        }

         public override void ResumoCliente()
        {
            base.ResumoCliente();
            Console.WriteLine($"{NumeroConta} | {RazaoSocial} | {CNPJ}");
        }
    }
}
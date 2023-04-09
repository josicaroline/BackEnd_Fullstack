
namespace M1S3_SistemaBanco.Model
{
    public abstract class Cliente
    {
        public int NumeroConta { get; set; }
        public string TipoConta { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public double Saldo {  get {return GetSaldo(); }  private set{} }

        
        public List<Transacao> Extrato { get; set; }

        public Cliente()
        {
            Extrato = new List<Transacao>();
        }
        public Cliente(int numeroConta, string tipoConta, string email, string telefone, string end) :this()
        {
            NumeroConta = numeroConta;
            TipoConta = tipoConta;
            Email = email;
            Telefone = telefone; 
            Endereco = end;
        }


        public virtual void ResumoCliente()
        {
           Console.WriteLine($"{NumeroConta} | {TipoConta}   | {Saldo}  ");
        }


        private double GetSaldo(){
            double saldo = 0;
            foreach(Transacao transacao  in Extrato){
                saldo += transacao.Valor;
            }
            return saldo;
        }
    }
}

namespace M1S3_SistemaBanco.Model
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Transacao (DateTime data, double valor){
            Data = data;
            
            Valor = valor;
        }

        public Transacao ()
        {
            
        }
    }
}
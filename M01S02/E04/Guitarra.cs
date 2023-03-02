using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E04
{
    public class Guitarra
    {
         private static string Afinacao { get; set; }

        static Guitarra()
        {
            Afinacao = "sol";
        }

        private static void TomAfinacao()
        {
            Console.WriteLine($"Guitarra com afinação em {Afinacao}");
        }

        public void Tocar(){
            TomAfinacao();    
        }

        public void Tocar(string afinacaoAtual)
        {
            Afinacao = afinacaoAtual;
            TomAfinacao();
        }
    }
}
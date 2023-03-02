using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E05
{
    public class Cobrar
    {
         private decimal Valor { get; set; }
        private decimal Multa { get; set; }

        public Cobrar (decimal valor, decimal multa)
        {
            Valor = valor;
            Multa = Multa;
        }

        public void Calcular()
            {
                decimal SomaValor = CalcularMulta();
                Console.WriteLine($"Valor cobrado {Valor}, Multa {Multa}, Soma Valor {SomaValor}");
            }

        private decimal CalcularMulta(){
           return Valor + Multa;
        }
    }
}
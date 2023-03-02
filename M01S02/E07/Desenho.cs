using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E07
{
    public static class Desenho
    {
         public static void Animacao()
        {
            Console.WriteLine("Animação Frozen");
        }

        public static void Animacao(string tipo)
        {
            Console.WriteLine($"Animação {tipo}");
        }
    }
}

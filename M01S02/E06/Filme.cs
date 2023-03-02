using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E06
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }

        public void MostrarFilme() 
        {
            Console.WriteLine($"Filme {NomeFilme}, categoria {Categoria}");       
    }
}
}

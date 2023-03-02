using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E02
{
    public class FichaInscricao
    {
         public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }


        public void MostrarFichaInscricao(){
            Console.WriteLine($" Código {Id}, Nome {Nome}, Data Nascimento {DataNascimento}");
        }
    }
}
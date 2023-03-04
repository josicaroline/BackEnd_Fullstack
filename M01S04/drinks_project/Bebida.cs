using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drinks_project
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal MiliLitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }

        public Bebida (int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra)
        {
            this.Id = id;
            this.Tipo = tipo;
            this.MiliLitro = miliLitro;
            this.NomeBebida = nomeBebida;
            this.ValorCompra = valorCompra;
        }

        public void Comprar()
        {
            Console.WriteLine($"Valor da compra do produto id {Id} alterado para {ValorCompra}");
        }
    }
}

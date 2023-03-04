using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace drinks_project
{
    public static class Repositorio
    {
        private static List<Bebida> ListaBebida { get; set; }
        private static List<Suco> ListaSuco { get; set; }
        private static List<Refrigerante> ListaRefrigerante { get; set; }

         static Repositorio()
        {
            if (ListaBebida == null) 
            {
                ListaBebida = new List<Bebida>();
            }

            if (ListaSuco == null) 
            {
                ListaSuco = new List<Suco>();
            }

            if (ListaRefrigerante == null) 
            {
                ListaRefrigerante = new List<Refrigerante>();
            }
        }

        public static void AdicionarBebida(Bebida bebida)
        {
            ListaBebida.Add(bebida);
        }

        public static void AdicionarSuco(Suco suco)
        {
            ListaSuco.Add(suco);
        }

        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {
            ListaRefrigerante.Add(refrigerante);
        }

        public static void AlterarBebida(Bebida bebida)
        {
            foreach (var item in ListaBebida.Where(w => w.Id == bebida.Id))
            {
                item.Id = bebida.Id;
            }
        }

        public static void ExcluirBebida(int id)
        {
            var localBebida = ListaBebida.FirstOrDefault(w => w.Id == id);   
            if (localBebida != null)
            {
                ListaBebida.Remove(localBebida);
            }
        }

        public static List<Bebida> ListarBebida()
        {
            return ListaBebida;
        }

        public static List<Suco> ListarSuco()
        {
            return ListaSuco;
        }

        public static List<Refrigerante> ListarRefrigerante()
        {
            return ListaRefrigerante;
        }

        public static void ImprimirSuco()
        {
            foreach (var suco in ListaSuco)
            {
                suco.ImprimirDados();
            }
        }

         public static void ImprimirRefrigerante()
        {
            foreach (var refrigerante in ListaRefrigerante)
            {
                refrigerante.ImprimirDados();
            }
        }
    }
}

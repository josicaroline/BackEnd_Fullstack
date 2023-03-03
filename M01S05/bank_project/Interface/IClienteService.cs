using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using M1S3_SistemaBanco.Model;


namespace M1S3_SistemaBanco.Interface
{
    public interface IClienteService
    {
        public void CriarConta();
        public Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        public void ExibirClientes();
    }
}
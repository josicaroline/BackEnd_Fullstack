using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using M1S3_SistemaBanco.Model;


namespace M1S3_SistemaBanco.Interface
{
    public interface IClienteService
    {
        public void CriarConta(Cliente cliente);
        public List<Cliente> ObterClientes();
        public List<Cliente> BuscarCliente(int id);
        public void DeletarCliente(int id);
        public Cliente AtualizarPessoaFisica(PessoaFisica pessoaFisica, int id);
        public Cliente AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica, int id);
        public void AdicionarTransacao(Transacao transacao, int idCliente);
        public List<Transacao> ListarTransacao(int idCliente);
    }
}
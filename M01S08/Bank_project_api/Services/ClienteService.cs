using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using M1S3_SistemaBanco.Model;
using M1S3_SistemaBanco.Interface;

namespace M1S3_SistemaBanco.Services
{
  public class ClienteService : IClienteService
  {
    static List<Cliente> _clientes = new List<Cliente>();

    public ClienteService()
    {

    }

    public void CriarConta(Cliente cliente)
    {
      _clientes.Add(cliente);
    }

    public List<Cliente> ObterClientes()
    {
      return _clientes;
    }

    public List<Cliente> BuscarCliente(int id)
    {
      var filtroclientes = _clientes.Where(x => x.NumeroConta == id).ToList();
      return filtroclientes;
    }

    public void DeletarCliente(int id)
    {
      var cliente = _clientes.Find(x => x.NumeroConta == id);
      _clientes.Remove(cliente);
    }

    public Cliente AtualizarPessoaFisica(PessoaFisica pessoaFisica, int id)
    {
      PessoaFisica newPF = null;

      List<Cliente> data = this.BuscarCliente(id);
      if (data.Count() > 0) {
        Cliente first = data[0];
        newPF = first as PessoaFisica;
      }

      if (pessoaFisica != null && newPF != null)
      {
        newPF.Email = pessoaFisica.Email;
        newPF.Telefone = pessoaFisica.Telefone;
        newPF.Endereco = pessoaFisica.Endereco;
        newPF.Nome = pessoaFisica.Nome;
        newPF.CPF = pessoaFisica.CPF;
        newPF.DataNascimento = pessoaFisica.DataNascimento;
        }
        return newPF;
      }

      public Cliente AtualizarPessoaJuridica(PessoaJuridica pessoaJuridica, int id)
      {
       PessoaJuridica newPJ = null;

      List<Cliente> data2 = this.BuscarCliente(id);
      if (data2.Count() > 0) {
        Cliente first1 = data2[0];
        newPJ = first1 as PessoaJuridica;
      }

        if (pessoaJuridica != null && newPJ != null)
        {
          newPJ.Email = pessoaJuridica.Email;
          newPJ.Telefone = pessoaJuridica.Telefone;
          newPJ.Endereco = pessoaJuridica.Endereco;
          newPJ.RazaoSocial = pessoaJuridica.RazaoSocial;
          newPJ.CNPJ = pessoaJuridica.CNPJ;
        }
        return newPJ;
      }

      public void AdicionarTransacao(Transacao transacao, int idCliente)
      {
        var cliente = _clientes.Find(x => x.NumeroConta == idCliente);
        cliente.Extrato.Add(transacao);
      }
     
      public List<Transacao> ListarTransacao(int idCliente)
      {
        var cliente = _clientes.Find(x => x.NumeroConta == idCliente);
        return cliente.Extrato;
      }
  }
}
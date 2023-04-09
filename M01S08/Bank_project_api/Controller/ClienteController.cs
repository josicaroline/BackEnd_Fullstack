using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using M1S3_SistemaBanco.Model;
using M1S3_SistemaBanco.Services;
using M1S3_SistemaBanco.Interface;

namespace M1S3_SistemaBanco.Controller
{
    [Route("cliente")]
    public class ClienteController : Controller
    {
        IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [Route("cliente")]
        public ActionResult GetClientes ([FromRoute] string nome)
        {
            if(string.IsNullOrEmpty(nome)) 
            {
                return Ok(_clienteService.ObterClientes());
            }
        }

        [HttpGet]
        [Route("cliente/{id}")]
        public ActionResult GetClientesId ([FromRoute] int id)
        {
            return Ok(_clienteService.BuscarCliente(id));
        }


        [HttpPost]
        [Route("cliente/pessoafisica")]
        public ActionResult PostPessoaFisica([FromBody] PessoaFisica pessoaFisica)
        {
            _clienteService.CriarConta(pessoaFisica);
            return Created(Request.Path, pessoaFisica);
        }

        [HttpPost]
        [Route("cliente/pessoajuridica")]
        public ActionResult PostPessoaJuridica([FromBody] PessoaJuridica pessoaJuridica)
        {
            _clienteService.CriarConta(pessoaJuridica);
            return Created(Request.Path, pessoaJuridica);
        }

        [HttpPut]
        [Route("cliente/pessoafisica/{id}")]
        public ActionResult AtualizarPessoaFisica([FromBody] PessoaFisica pessoaFisica, [FromRoute] int id)
        {
            _clienteService.AtualizarPessoaFisica(pessoaFisica, id);
            return Ok();
        }

        [HttpPut]
        [Route("cliente/pessoajuridica/{id}")]
        public ActionResult AtualizarPessoaJuridica([FromBody] PessoaJuridica pessoaJuridica, [FromRoute] int id)
        {
            _clienteService.AtualizarPessoaJuridica(pessoaJuridica, id);
            return Ok();
        }

        [HttpDelete]
        [Route("cliente/{id}")]
        public ActionResult DeletarCliente([FromRoute] int id)
        {
            Cliente clienteDelete = _clienteService.BuscarCliente(id);

            if (clienteDelete.Saldo != 0)
            {
                return BadRequest($"Não foi possível deletar sua conta. O cliente ainda possui um saldo de: {clienteDelete.Saldo}");
            }


            _clienteService.DeletarCliente(id);
            return Ok();
        }
    }
}
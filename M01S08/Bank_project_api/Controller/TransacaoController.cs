using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using M1S3_SistemaBanco.Model;
using M1S3_SistemaBanco.Interface;

namespace M1S3_SistemaBanco.Controller
{
    [Route("transacao")]
    public class TransacaoController : Controller
    {
        private IClienteService _clienteService;

        public TransacaoController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        [Route("transacao/{idCliente}")]
        public ActionResult AdicionarTransacao([FromBody] Transacao transacao, [FromRoute] int idCliente)
        {
            _clienteService.AdicionarTransacao(transacao, idCliente);
            return Created(Request.Path, transacao);
        }

        [HttpGet]
        [Route("transacao/{idCliente}")]
        public ActionResult ListarTransacao([FromRoute] int idCliente)
        {
            return Ok(_clienteService.ListarTransacao(idCliente));
        }
    }
}
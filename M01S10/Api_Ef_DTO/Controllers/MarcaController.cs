using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Api_Ef_DTO.Model;
using Api_Ef_DTO.DTO;


namespace Api_Ef_DTO.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcaController : ControllerBase
    {
        private readonly LocacaoContext locacaoContext;

        public MarcaController(LocacaoContext locacaoContext)
        {
            this.locacaoContext = locacaoContext;
        }


        [HttpPost]
        public ActionResult<MarcaDTO> Post([FromBody] MarcaDTO marcaDTO)
        {
            MarcaModel marcaModel = new MarcaModel();
            marcaModel.Nome = marcaDTO.Nome;
           
            var marcaCodigo = locacaoContext.Marca.Find(marcaDTO.Codigo);

            if (marcaCodigo != null)
            {
                locacaoContext.Marca.Add(marcaModel);
                locacaoContext.SaveChanges();
                marcaDTO.Nome = marcaModel.Nome;
                return Ok(marcaDTO);
            }
            else
            {
                return BadRequest("Erro ao salvar no banco de dados");
            }
        }


        [HttpPut]
        public ActionResult<MarcaDTO> Put([FromBody] MarcaDTO marcaDTO)
        {
            var marcaModel = locacaoContext.Marca.Where(w => w.Id == marcaDTO.Codigo).FirstOrDefault();

            if (marcaModel == null)
            {
                return BadRequest("Erro ao atualizar o registro");
            }
            
            marcaModel.Nome = marcaDTO.Nome;
            marcaModel.Id = marcaDTO.Codigo;

            locacaoContext.Marca.Attach(marcaModel);
            locacaoContext.SaveChanges();
            return Ok(marcaDTO);
        }


        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var marcaModel = locacaoContext.Marca.Find(id);

            if (marcaModel != null)
            {
                locacaoContext.Marca.Remove(marcaModel);
                locacaoContext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest("Erro ao deletar o registro");
            }
        }

    
        [HttpGet]
        public ActionResult<List<MarcaDTO>> Get()
        {
            var listaMarcaModel = locacaoContext.Marca;
            List<MarcaDTO> listaGetDto = new List<MarcaDTO>();

            foreach (var item in listaMarcaModel)
            {
                var marcaDto = new MarcaDTO();
                marcaDto.Codigo = item.Id;
                marcaDto.Nome = item.Nome;

                listaGetDto.Add(marcaDto);
            }

            return Ok(listaGetDto);
        }

        
        [HttpGet]
        [Route("{id}")]
        public ActionResult<MarcaDTO> Get([FromRoute] int id)
        {
            var marcaModel = locacaoContext.Marca.Find(id);
            
            if (marcaModel == null)
            {
                return BadRequest("Dados não foram encontrados no banco");
            }

            MarcaDTO marcaDTO = new MarcaDTO();
            marcaDTO.Codigo = marcaModel.Id;
            marcaDTO.Nome = marcaModel.Nome;

            return Ok(marcaDTO);
        }
    }
}
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
    public class CarroController : ControllerBase
    {
        private readonly LocacaoContext locacaoContext;

        public CarroController(LocacaoContext locacaoContext)
        {
            this.locacaoContext = locacaoContext;
        }


        [HttpPost]
        public ActionResult<CarroDTO> Post([FromBody] CarroDTO carroDTO)
        {
            CarroModel carroModel = new CarroModel();
            carroModel.Nome = carroDTO.DescricaoCarro;
            carroModel.Id = carroDTO.Codigo;
            carroModel.DataLocacao = carroDTO.DataLocacao;
    
            locacaoContext.Carro.Add(carroModel);
            locacaoContext.SaveChanges();
            carroDTO.Codigo = carroModel.Id;
            return Ok(carroDTO);
        }


        [HttpPut]
        public ActionResult<CarroDTO> Put([FromBody] CarroDTO carroDTO)
        {
            var carroModel = locacaoContext.Carro.Where(w => w.Id == carroDTO.Codigo).FirstOrDefault();

            if (carroModel == null)
            {
                return BadRequest("Erro ao atualizar o registro");
            }
            
            carroModel.Nome = carroDTO.DescricaoCarro;
            carroModel.Id = carroDTO.Codigo;
            carroModel.DataLocacao = carroDTO.DataLocacao;

            locacaoContext.Carro.Attach(carroModel);
            locacaoContext.SaveChanges();
            return Ok(carroDTO);
        }


        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var carroModel = locacaoContext.Carro.Find(id);

            if (carroModel != null)
            {
                locacaoContext.Carro.Remove(carroModel);
                locacaoContext.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest("Erro ao deletar o registro");
            }
        }


        [HttpGet]
        public ActionResult<List<CarroDTO>> Get()
        {
            var listaCarroModel = locacaoContext.Carro;
            List<CarroDTO> listaGetDto2 = new List<CarroDTO>();

            foreach (var item in listaCarroModel)
            {
                var carroDto = new CarroDTO();
                carroDto.Codigo = item.Id;
                carroDto.DescricaoCarro = item.Nome;

                listaGetDto2.Add(carroDto);
            }

            return Ok(listaGetDto2);
        }

        
        [HttpGet]
        [Route("{id}")]
        public ActionResult<CarroDTO> Get([FromRoute] int id)
        {
            var carroModel = locacaoContext.Carro.Find(id);
            
            if (carroModel == null)
            {
                return BadRequest("Dados não foram encontrados no banco");
            }

            CarroDTO carroDTO = new CarroDTO();
            carroDTO.Codigo = carroModel.Id;
            carroDTO.DescricaoCarro = carroModel.Nome;

            return Ok(carroDTO);
        }        
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using First_Api_Ef.Model;


namespace First_Api_Ef.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SemanaController : ControllerBase
    {
        private readonly SemanaContext semanaContext;

        public SemanaController(SemanaContext semanaContext)
        {
            this.semanaContext = semanaContext;
        }

        [HttpGet]
        public ActionResult<List<SemanaModel>> Get()
        {
            List<SemanaModel> lista = new List<SemanaModel>();
            IQueryable<SemanaModel> semanasInnerJoin = semanaContext.Semana.Include(c => c);
            return Ok(semanasInnerJoin);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<SemanaModel> Get([FromRoute] int id)
        {
            var semanaModel = semanaContext.Semana.Where(w => w.Id == id).FirstOrDefault();

            if (semanaModel == null)
            {
                return BadRequest("Dados não foram encontrados no banco");
            }
           
            return Ok(semanaModel);
        }

        [HttpPost]
        public ActionResult<SemanaModel> Post([FromBody] SemanaModel semanaModel)
        {
            if (semanaModel == null || semanaModel.Id > 0) {
                return BadRequest("Semana é nula ou Id maior que zero, dados não serão inseridos");
            }

            var existente = semanaContext.Semana.Find(semanaModel.Id);
            if (existente != null) {
                return BadRequest("Dados já existentes");
            }    
            
            semanaContext.Semana.Add(semanaModel);
            semanaContext.SaveChanges();
            return Ok(semanaModel);
        }
            
        [HttpPut]
        public ActionResult<SemanaModel> Put([FromBody] SemanaModel semanaModel)
        {
            var existente = semanaContext.Semana.Where(w => w.Id == semanaModel.Id).FirstOrDefault();
            
            if (existente == null)
            {
                return BadRequest("Registro não é existente");
            }
           
            //semanaContext.Semana.Attach(semanaModel);
            semanaContext.Semana.Update(semanaModel);
            semanaContext.SaveChanges();
            return Ok(semanaModel);           
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            var semanaModel = semanaContext.Semana.Find(id);

            if (semanaModel == null)
            {
                return BadRequest("Registro não é existente");
            }

            semanaContext.Semana.Remove(semanaModel);
            semanaContext.SaveChanges();
            return Ok();
            }
        }
    }
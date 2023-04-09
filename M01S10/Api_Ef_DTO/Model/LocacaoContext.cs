using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Api_Ef_DTO.Model
{
    public class LocacaoContext : DbContext 
    {
        public LocacaoContext(DbContextOptions<LocacaoContext> options) : base(options)
        {
            
        }

        public DbSet<CarroModel> Carro { get; set; }

        public DbSet<MarcaModel> Marca { get; set; }
    }
}
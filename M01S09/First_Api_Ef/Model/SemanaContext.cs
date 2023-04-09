using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace First_Api_Ef.Model
{
    public class SemanaContext : DbContext
    {
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {
            
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\.;database=Modulo1Semana9;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        } */

        public DbSet<SemanaModel> Semana { get; set; }

    }
}
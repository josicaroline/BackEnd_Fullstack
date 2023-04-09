using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace First_Api_Ef.Model
{
    [Table("Semana")]
    public class SemanaModel
    {
        [Key]
        [Column("CODIGO")]  
        public int Id { get; set; }
        public DateTime DataSemana { get; set; } 
        public bool AplicadoConteudo { get; set; } 

        [MaxLength(100)]
        public string Conteudo { get; set; } 
    }
}
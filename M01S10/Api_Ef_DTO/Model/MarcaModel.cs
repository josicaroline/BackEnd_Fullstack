using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Ef_DTO.Model
{
    [Table("Marcas")]
    public class MarcaModel
    {
        [Key]
        [Column("CODIGO")]  
        public int Id { get; set; }
        public string? Nome { get; set; } 
    }
}
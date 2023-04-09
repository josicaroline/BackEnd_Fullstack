using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Ef_DTO.Model
{
    [Table("Carros")]
    public class CarroModel
    {
        [Key]
        [Column("CODIGO")]  
        public int Id { get; set; }
        public string? Nome { get; set; } 
        public DateTime DataLocacao { get; set; }

        [ForeignKey("CarroModel")]
        public List<MarcaModel>? Marcas { get; set; } 
    }
}

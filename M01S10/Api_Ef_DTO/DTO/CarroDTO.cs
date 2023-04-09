using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Ef_DTO.DTO
{
    public class CarroDTO
    {
        public int Codigo { get; set; }
        public string? DescricaoCarro { get; set; }
        public int CodigoMarca { get; set; }
        public DateTime DataLocacao { get; set; }
        public string? DescricaoMarca { get; set; }    //varchar
    }
}
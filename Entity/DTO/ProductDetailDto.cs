using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO
{
    public class ProductDetailDto:IDto
    {
        public int CartId { get; set; }
        public string CarName { get; set; }
        public string ColorName { get; set; }
        public short UnitInStock { get; set; }

    }
}

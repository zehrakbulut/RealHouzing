using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.EntityLayer.Concrete
{
    public class Product
    {   
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductType { get; set; }
        public string ProductAddress { get; set; }
        public int BedRoomCount { get; set; }
        public int BathCount { get; set; }
        public int Square { get; set; }
        public string CoverImageUrl { get; set; }
        public bool IsItDone { get; set; }

        public Category Category { get; set; }
        public int CategoryID { get; set; }
    }
}

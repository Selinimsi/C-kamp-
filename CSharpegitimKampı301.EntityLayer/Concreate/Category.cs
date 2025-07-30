using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpegitimKampı301.EntityLayer.Concreate
{
     public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }//bir categoride birden fazla ürün bulunabilir
        public List<Order> Orders { get; set; }
    }
}

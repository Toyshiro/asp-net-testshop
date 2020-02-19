using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Adress { get; set; }
        public string ContactPhone{ get; set; }

        public int ProductId { get; set; }
        public Product Product{ get; set; }
    }
}

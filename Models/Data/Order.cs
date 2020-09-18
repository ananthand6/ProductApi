using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductAPI.Models.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> ProductName { get; set; }
        public Customer Customer { get; set; }

    }
}

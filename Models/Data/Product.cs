using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models.Data
{
    public class Product
    {
      
        public int Productid { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
       
    }
}

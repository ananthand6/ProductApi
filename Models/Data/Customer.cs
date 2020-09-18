using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models.Data
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }        
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
       
    }
}

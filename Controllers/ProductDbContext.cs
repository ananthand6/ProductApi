using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Models.Data;

namespace ProductManagement.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
        {
        }
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Productdetails { get; set; }
        public DbSet<Order> Orderdetails { get; set; }
        public DbSet<Customer> Customerdetails { get; set; }


    }

}


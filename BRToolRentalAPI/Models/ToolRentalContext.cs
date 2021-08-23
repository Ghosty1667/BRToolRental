using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRToolRentalAPI.Models
{
    public class ToolRentalContext : DbContext
    {
        public ToolRentalContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Tool> Tools { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Tool>().HasData(
                new Tool
                {
                    ToolId = 1,
                    ToolBrand = "Makita",
                    ToolName = "Hammer",
                    ToolCondition = "New"
                });

            builder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Steve",
                    CustomerEmail = "Steve@email.com",
                    CustomerPhone = "1234"
                });

            builder.Entity<Rental>().HasData(
                new Rental
                {
                    RentalID = 1,
                    CustomerId = 1,
                    ToolId = 1,
                    Rented = DateTime.Now
                });


        }

    }
}

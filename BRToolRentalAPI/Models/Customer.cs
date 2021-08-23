using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRToolRentalAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        // Relationships

        public ICollection<Rental> Rentals { get; set; }


    }
}

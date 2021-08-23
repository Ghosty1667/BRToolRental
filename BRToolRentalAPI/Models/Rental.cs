using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRToolRentalAPI.Models
{
    public class Rental
    {
        public int RentalID { get; set; }
        public DateTime Rented  { get; set; }
        public DateTime? Returned { get; set; }
        public string Notes { get; set; }
        public int ToolId { get; set; }
        public int CustomerId { get; set; }

        // Relationships
        public Tool Tool { get; set; }
        public Customer Customer { get; set; }
    }
}

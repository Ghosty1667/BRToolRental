using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRToolRentalAPI.Models
{
    public class Tool
    {
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string ToolBrand { get; set; }
        public string ToolCondition { get; set; }
        public bool Available { get; set; }

        // Relationships
        public ICollection<Rental> Rentals { get; set; }


    }
}

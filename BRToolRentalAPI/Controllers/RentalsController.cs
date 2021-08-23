using BRToolRentalAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRToolRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        ToolRentalContext _context;
        public RentalsController(ToolRentalContext context)
        {
            _context = context;
        }


        // GET: api/<ToolController>
        [HttpGet]
        public IEnumerable<Rental> Get()
        {
            return _context.Rentals.ToList();
        }

        // GET api/<ToolController>/5
        [HttpGet("{id}")]
        public Rental Get(int id)
        {
            return _context.Rentals.Find(id);
        }

        // POST api/<ToolController>
        [HttpPost]
        public IActionResult Post(Rental rental)
        {
            if (rental != null)
            {
                _context.Rentals.Add(rental);
                return Ok(rental);
            }
            return BadRequest();
        }

        // PUT api/<ToolController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Rental rental)
        {
            var existingRental = _context.Rentals.Find(rental.CustomerId);
            if (existingRental != null)
            {
                _context.Rentals.Update(rental);
                _context.SaveChanges();
                return Ok(rental);
            }
            return NotFound();
        }

        // DELETE api/<ToolController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingRental = _context.Rentals.Find(id);
            if (existingRental != null)
            {
                _context.Rentals.Remove(existingRental);
                _context.SaveChanges();
                return Ok(existingRental);
            }
            return NotFound();

        }
    }
}

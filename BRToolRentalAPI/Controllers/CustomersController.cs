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
    public class CustomersController : ControllerBase
    {
        ToolRentalContext _context;
        public CustomersController(ToolRentalContext context)
        {
            _context = context;
        }


        // GET: api/<ToolController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.Customers.ToList();
        }

        // GET api/<ToolController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _context.Customers.Find(id);
        }

        // POST api/<ToolController>
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            if (customer != null)
            {
                _context.Customers.Add(customer);
                return Ok(customer);
            }
            return BadRequest();
        }

        // PUT api/<ToolController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Customer customer)
        {
            var existingCustomer = _context.Customers.Find(customer.CustomerId);
            if (existingCustomer != null)
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return Ok(customer);
            }
            return NotFound();
        }

        // DELETE api/<ToolController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingCustomer = _context.Customers.Find(id);
            if (existingCustomer != null)
            {
                _context.Customers.Remove(existingCustomer);
                _context.SaveChanges();
                return Ok(existingCustomer);
            }
            return NotFound();

        }
    }
}

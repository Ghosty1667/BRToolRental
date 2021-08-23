using BRToolRentalAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BRToolRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        ToolRentalContext _context;
        public ToolsController(ToolRentalContext context)
        {
            _context = context;
        }


        // GET: api/<ToolController>
        [HttpGet]
        public IEnumerable<Tool> Get()
        {
            return _context.Tools.ToList();
        }

        // GET api/<ToolController>/5
        [HttpGet("{id}")]
        public Tool Get(int id)
        {
            return _context.Tools.Find(id);
        }

        // POST api/<ToolController>
        [HttpPost]
        public IActionResult Post(Tool tool)
        {
            if(tool != null)
            {
                _context.Tools.Add(tool);
                _context.SaveChanges();
                return Ok(tool);
            }
            return BadRequest();
        }

        // PUT api/<ToolController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, Tool tool)
        {
            var existingTool = _context.Tools.Find(tool.ToolId);
            if(existingTool != null)
            {
                _context.Tools.Update(tool);
                _context.SaveChanges();
                return Ok(tool);
            }
            return NotFound();
        }

        // DELETE api/<ToolController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingTool = _context.Tools.Find(id);
            if (existingTool != null)
            {
                _context.Tools.Remove(existingTool);
                _context.SaveChanges();
                return Ok(existingTool);
            }
            return NotFound();

        }
    }
}

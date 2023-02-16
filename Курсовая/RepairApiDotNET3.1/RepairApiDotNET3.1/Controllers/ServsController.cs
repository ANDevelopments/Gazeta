using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepairApiDotNET3.Models;

namespace RepairApiDotNET3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServsController : ControllerBase
    {
        private readonly RepairDbContext _context;

        public ServsController(RepairDbContext context)
        {
            _context = context;
        }

        // GET: api/Servs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Serv>>> GetServs()
        {
            return await _context.Servs.ToListAsync();
        }

        // GET: api/Servs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Serv>> GetServ(int id)
        {
            var serv = await _context.Servs.FindAsync(id);

            if (serv == null)
            {
                return NotFound();
            }

            return serv;
        }

        // PUT: api/Servs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServ(int id, Serv serv)
        {
            if (id != serv.ID)
            {
                return BadRequest();
            }

            _context.Entry(serv).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Servs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Serv>> PostServ(Serv serv)
        {
            _context.Servs.Add(serv);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetServ", new { id = serv.ID }, serv);
        }

        // DELETE: api/Servs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Serv>> DeleteServ(int id)
        {
            var serv = await _context.Servs.FindAsync(id);
            if (serv == null)
            {
                return NotFound();
            }

            _context.Servs.Remove(serv);
            await _context.SaveChangesAsync();

            return serv;
        }

        private bool ServExists(int id)
        {
            return _context.Servs.Any(e => e.ID == id);
        }
    }
}

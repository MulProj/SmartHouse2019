using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Models.Database;

namespace WebApplication3.Controllers
{
/*    [Route("api/[controller]")]
    [ApiController]
    public class Houses1Controller : ControllerBase
    {
        private readonly DatabaseContext _context;

        public Houses1Controller(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Houses1
        [HttpGet]
        public IEnumerable<House> GetHouses()
        {
            return _context.Houses;
        }

        // GET: api/Houses1/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHouse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var house = await _context.Houses.FindAsync(id);

            if (house == null)
            {
                return NotFound();
            }

            return Ok(house);
        }

        // PUT: api/Houses1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHouse([FromRoute] int id, [FromBody] House house)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != house.HouseId)
            {
                return BadRequest();
            }

            _context.Entry(house).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HouseExists(id))
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

        // POST: api/Houses1
        [HttpPost]
        public async Task<IActionResult> PostHouse([FromBody] House house)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Houses.Add(house);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHouse", new { id = house.HouseId }, house);
        }

        // DELETE: api/Houses1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHouse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var house = await _context.Houses.FindAsync(id);
            if (house == null)
            {
                return NotFound();
            }

            _context.Houses.Remove(house);
            await _context.SaveChangesAsync();

            return Ok(house);
        }

        private bool HouseExists(int id)
        {
            return _context.Houses.Any(e => e.HouseId == id);
        }
    }*/
}
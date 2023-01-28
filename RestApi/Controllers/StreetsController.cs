using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreetsController : ControllerBase
    {
        private readonly StreetsContext _context;

        public StreetsController(StreetsContext context)
        {
            _context = context;
        }

        // GET: api/Streets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StreetsModel>>> GetStreetsModel()
        {
            return await _context.StreetsModel.ToListAsync();
        }

        // GET: api/Streets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StreetsModel>> GetStreetsModel(int id)
        {
            var streetsModel = await _context.StreetsModel.FindAsync(id);

            if (streetsModel == null)
            {
                return NotFound();
            }

            return streetsModel;
        }
        /*
        // PUT: api/Streets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStreetsModel(int id, StreetsModel streetsModel)
        {
            if (id != streetsModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(streetsModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StreetsModelExists(id))
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

        // POST: api/Streets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StreetsModel>> PostStreetsModel(StreetsModel streetsModel)
        {
            _context.StreetsModel.Add(streetsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStreetsModel", new { id = streetsModel.Id }, streetsModel);
        }

        // DELETE: api/Streets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStreetsModel(int id)
        {
            var streetsModel = await _context.StreetsModel.FindAsync(id);
            if (streetsModel == null)
            {
                return NotFound();
            }

            _context.StreetsModel.Remove(streetsModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
        private bool StreetsModelExists(int id)
        {
            return _context.StreetsModel.Any(e => e.Id == id);
        }
    }
}

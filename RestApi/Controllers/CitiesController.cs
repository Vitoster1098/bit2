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
    public class CitiesController : ControllerBase
    {
        private readonly CitiesContext _context;

        public CitiesController(CitiesContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitiesModel>>> GetCitiesModel()
        {
            return await _context.CitiesModel.ToListAsync();
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CitiesModel>> GetCitiesModel(int id)
        {
            var citiesModel = await _context.CitiesModel.FindAsync(id);

            if (citiesModel == null)
            {
                return NotFound();
            }

            return citiesModel;
        }
        /*
        // PUT: api/Cities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCitiesModel(int id, CitiesModel citiesModel)
        {
            if (id != citiesModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(citiesModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitiesModelExists(id))
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

        // POST: api/Cities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CitiesModel>> PostCitiesModel(CitiesModel citiesModel)
        {
            _context.CitiesModel.Add(citiesModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCitiesModel", new { id = citiesModel.Id }, citiesModel);
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitiesModel(int id)
        {
            var citiesModel = await _context.CitiesModel.FindAsync(id);
            if (citiesModel == null)
            {
                return NotFound();
            }

            _context.CitiesModel.Remove(citiesModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */

        private bool CitiesModelExists(int id)
        {
            return _context.CitiesModel.Any(e => e.Id == id);
        }
    }
}

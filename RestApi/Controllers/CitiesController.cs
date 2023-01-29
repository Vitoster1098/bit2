using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesContext _context;
        private readonly StreetsContext _streetsContext;

        public CitiesController(CitiesContext context, StreetsContext streetsContext)
        {
            _context = context;
            _streetsContext = streetsContext;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitiesModel>>> GetCitiesModel()
        {
            return await _context.CitiesModel.ToListAsync();
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CitiesModel>>> GetCitiesModel(int id)
        {
            var citiesModel = await _context.CitiesModel.Where(m => m.Id == id).ToListAsync();
            if(citiesModel == null)
            {
                return NotFound();
            }
            return citiesModel;
        }

        // GET: api/Cities/5/Streets
        [HttpGet("{id}/streets")]
        public async Task<ActionResult<IEnumerable<StreetsModel>>> GetStreetsByCityId(int id)
        {
            var steetsModel = await _context.StreetsModel.Where(m =>m.Id == id).ToListAsync();
            if (steetsModel == null)
            {
                return NotFound();
            }
            return steetsModel;
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

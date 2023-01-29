using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly ApartmentsContext _context;

        public ApartmentsController(ApartmentsContext context)
        {
            _context = context;
        }

        // GET: api/Apartments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApartmentsModel>>> GetApartmentsModel()
        {
            return await _context.ApartmentsModel.ToListAsync();
        }

        // GET: api/Apartments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApartmentsModel>> GetApartmentsModel(int id)
        {
            var apartmentsModel = await _context.ApartmentsModel.FindAsync(id);

            if (apartmentsModel == null)
            {
                return NotFound();
            }

            return apartmentsModel;
        }

        // PUT: api/Apartments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApartmentsModel(int id, ApartmentsModel apartmentsModel)
        {
            if (id != apartmentsModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(apartmentsModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApartmentsModelExists(id))
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

        // POST: api/Apartments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApartmentsModel>> PostApartmentsModel(ApartmentsModel apartmentsModel)
        {
            _context.ApartmentsModel.Add(apartmentsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApartmentsModel", new { id = apartmentsModel.Id }, apartmentsModel);
        }

        // DELETE: api/Apartments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApartmentsModel(int id)
        {
            var apartmentsModel = await _context.ApartmentsModel.FindAsync(id);
            if (apartmentsModel == null)
            {
                return NotFound();
            }

            _context.ApartmentsModel.Remove(apartmentsModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApartmentsModelExists(int id)
        {
            return _context.ApartmentsModel.Any(e => e.Id == id);
        }
    }
}

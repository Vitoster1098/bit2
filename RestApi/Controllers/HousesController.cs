using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly HousesContext _context;

        public HousesController(HousesContext context)
        {
            _context = context;
        }

        // GET: api/Houses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HousesModel>>> GetHousesModel()
        {
            return await _context.HousesModel.ToListAsync();
        }

        // GET: api/Houses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HousesModel>> GetHousesModel(int id)
        {
            var housesModel = await _context.HousesModel.FindAsync(id);

            if (housesModel == null)
            {
                return NotFound();
            }

            return housesModel;
        }
        /*
        // PUT: api/Houses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHousesModel(int id, HousesModel housesModel)
        {
            if (id != housesModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(housesModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HousesModelExists(id))
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

        // POST: api/Houses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HousesModel>> PostHousesModel(HousesModel housesModel)
        {
            _context.HousesModel.Add(housesModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHousesModel", new { id = housesModel.Id }, housesModel);
        }

        // DELETE: api/Houses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHousesModel(int id)
        {
            var housesModel = await _context.HousesModel.FindAsync(id);
            if (housesModel == null)
            {
                return NotFound();
            }

            _context.HousesModel.Remove(housesModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
        private bool HousesModelExists(int id)
        {
            return _context.HousesModel.Any(e => e.Id == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ILA3_0110.Models;

namespace ILA3_0110.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolYearsController : ControllerBase
    {
        private readonly ILA3_0110DbContext _context;

        public SchoolYearsController(ILA3_0110DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchoolYear>>> GetSchoolYears()
        {
            return await _context.SchoolYears.Include(sy => sy.Classrooms).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolYear>> GetSchoolYear(int id)
        {
            var schoolYear = await _context.SchoolYears.Include(sy => sy.Classrooms).FirstOrDefaultAsync(sy => sy.Id == id);

            if (schoolYear == null)
                return NotFound();

            return schoolYear;
        }

        [HttpPost]
        public async Task<ActionResult<SchoolYear>> CreateSchoolYear(SchoolYear schoolYear)
        {
            _context.SchoolYears.Add(schoolYear);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSchoolYear), new { id = schoolYear.Id }, schoolYear);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSchoolYear(int id, SchoolYear schoolYear)
        {
            if (id != schoolYear.Id)
                return BadRequest();

            _context.Entry(schoolYear).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.SchoolYears.Any(e => e.Id == id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchoolYear(int id)
        {
            var schoolYear = await _context.SchoolYears.FindAsync(id);
            if (schoolYear == null)
                return NotFound();

            _context.SchoolYears.Remove(schoolYear);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

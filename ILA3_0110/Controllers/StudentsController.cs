using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using ILA3_0110.Models;
using Microsoft.EntityFrameworkCore;

namespace ILA3_0110.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ILA3_0110DbContext _context;

        public StudentsController(ILA3_0110DbContext context)
        {
            _context = context;
        }

        // POST: api/students
        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            // Assign classroom based on student age or other criteria
            student.ClassroomId = AssignClassroomId(student.BirthDate); // Assign classroom automatically based on criteria

            // Check if the classroom exists
            var classroom = await _context.Classrooms.FindAsync(student.ClassroomId);
            if (classroom == null)
            {
                return NotFound("Classroom not found.");
            }

            // Add the student to the context
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.Id }, student);
        }

        // GET: api/students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.Include(s => s.Classroom).ToListAsync(); // Include related classroom data
        }

        // GET: api/students/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            if (_context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return new Student
            {
                Id = student.Id,
               FirstName = student.FirstName,
               LastName = student.LastName
            };
        }


        // PUT: api/students/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            // Reassign classroom based on updated criteria
            student.ClassroomId = AssignClassroomId(student.BirthDate); // Reassign classroom automatically

            // Check if the classroom exists
            var classroom = await _context.Classrooms.FindAsync(student.ClassroomId);
            if (classroom == null)
            {
                return NotFound("Classroom not found.");
            }

            // Update the student
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/students/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private int AssignClassroomId(DateOnly birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;

            if (age < 6)
            {
                return 1; // Kindergarten
            }
            else if (age >= 6 && age < 10)
            {
                return 2; // Elementary
            }
            else if (age >= 10 && age < 14)
            {
                return 3; // Middle School
            }
            else
            {
                return 4; // High School
            }
        }
    }
}

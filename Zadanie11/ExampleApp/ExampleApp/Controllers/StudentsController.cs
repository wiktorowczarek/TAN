using ExampleApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ExampleApp.Controllers
{
    public class StudentsController : Controller
    {

        private PgagoContext _context;

        public StudentsController(PgagoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync();
            ViewData["Login"] = "Jan Kowalski";

            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            student.IdStatus = 1;
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return Redirect(nameof(Index));
        }
    }
}

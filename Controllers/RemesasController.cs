using Microsoft.AspNetCore.Mvc;
using MELIPARCIAL.Models;
using MELIPARCIAL.Data; 
using Microsoft.EntityFrameworkCore; 
using System.Threading.Tasks; 

namespace MELIPARCIAL.Controllers
{
    public class RemesasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RemesasController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            var remesas = _context.Remesas.ToList(); 
            return View(remesas);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Remesa remesa)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(remesa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(remesa); 
        }
    }
}

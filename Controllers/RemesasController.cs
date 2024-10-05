using Microsoft.AspNetCore.Mvc;
using MELIPARCIAL.Data;

public class RemesasController : Controller
{
    private readonly ApplicationDbContext _context;

    public RemesasController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Acciones para agregar y listar remesas
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
    public IActionResult Create(Remesa remesa)
    {
        if (ModelState.IsValid)
        {
            _context.Remesas.Add(remesa);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(remesa);
    }
}

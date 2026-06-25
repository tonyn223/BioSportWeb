using Microsoft.AspNetCore.Mvc;
using BioSportWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace BioSportWeb.Controllers
{
    public class PlanesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlanesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Esto intenta traer los datos de tu tabla 'Planes' en SQL
            var planes = await _context.Planes.ToListAsync();
            return View(planes);
        }
    }
}
using IntroAsp.Models;
using IntroAsp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace IntroAsp.Controllers
{
    public class BeerController : Controller
    {

        private readonly PubContext _context;

        public BeerController(PubContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var beers = _context.Cervezas.Include(b => b.IdBrandNavigation);
            
            return View(await beers.ToListAsync());
        }

        public IActionResult Create()
        {
            ViewData["Brands"] = new SelectList(_context.Brands,"IdBrand","Nombre");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BeerViewModels beerModel)
        {
            if (ModelState.IsValid)
            {
                var beer = new Cerveza
                {
                    Nombre = beerModel.Nombre,
                    IdBrand = beerModel.IdBrand,
                };
                _context.Add(beer);
                await _context.SaveChangesAsync();  
                return RedirectToAction("Index");
            }


            ViewData["Brands"] = new SelectList(_context.Brands, "IdBrand", "Nombre");
            return View(beerModel);
        }
    }
}

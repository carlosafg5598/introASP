using introASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace introASP.Controllers
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
            //TODO ARREGLAR AQUI
            var beers = _context.Cervezas.Include(b=>b.Nombre);
            return View(await beers.ToListAsync());
        }
    }
}

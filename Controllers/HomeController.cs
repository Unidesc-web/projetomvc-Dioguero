using Microsoft.AspNetCore.Mvc;
using LanchoneteApp.Models;

namespace LanchoneteApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly LanchoneteContext _context;
        
        public HomeController(LanchoneteContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var produtos = _context.Produtos.Where(p => p.Disponivel).ToList();
            return View(produtos);
        }
    }
}
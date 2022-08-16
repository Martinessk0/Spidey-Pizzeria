using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public ApplicationDbContext _context;
        public PizzaModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<PizzasModel> PizzaDB = new List<PizzasModel>();
        public void OnGet()
        {
            _context.PizzasModels.ToList();
        }
    }
}

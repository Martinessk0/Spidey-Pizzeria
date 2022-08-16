using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        private readonly ApplicationDbContext _contex;

        public CreateModel(ApplicationDbContext context)
        {
            _contex = context;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzasModel pizza=new PizzasModel()
            {
                PizzaName=Pizza.PizzaName,
                ImageTitle=Pizza.PizzaName,
                TomatoSause=Pizza.TomatoSause,
                Cheese=Pizza.Cheese,
                Peperoni = Pizza.Peperoni,
                Mushroom = Pizza.Mushroom,
                Tuna = Pizza.Tuna,
                Pineapple = Pizza.Pineapple,
                Ham = Pizza.Ham,
                Beef = Pizza.Beef,
            };
            _contex.PizzasModels.Add(pizza);
            _contex.SaveChanges();
            return RedirectToPage("/Checkout/Successful");
        }
    }
}

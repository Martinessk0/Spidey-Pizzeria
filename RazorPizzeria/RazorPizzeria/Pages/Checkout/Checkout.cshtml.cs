using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    { 
        public string PizzaName { get; set; }
        public decimal PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom";
            if (string.IsNullOrWhiteSpace(ImageTitle)) ImageTitle = "Create";
            PizzaOrder pizzaOrder = new PizzaOrder()
            {
                PizzaName = PizzaName,
                Price=PizzaPrice
            };
            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }
}

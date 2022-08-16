using System.ComponentModel.DataAnnotations;

namespace RazorPizzeria.Models
{
    public class PizzasModel 
    {
        [Key]
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public string ImageTitle { get; set; }
        public decimal BasePrice { get; set; } = 4;
        public bool TomatoSause { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }

        public decimal FinalPrice { get; set; }


    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPizzeria.Models;

namespace WebPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() 
        { 
           new PizzasModel ()
           {
               ImageTitle="PeperoniPizza", 
               PizzaName="Magerita", 
               BasePrice=2, 
               TomatoSauce = true,
               Cheese = true,
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="Magerita",
               PizzaName="Magerita",
               BasePrice=2,
               TomatoSauce = true,
               Cheese = true,
               FinalPrice = 4
           },

        };

        public void OnGet()
        {
        }
    }
}

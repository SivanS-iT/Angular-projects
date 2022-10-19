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
               ImageTitle="CheesePizza", 
               PizzaName="CheesePizza", 
               BasePrice=2, 
               TomatoSauce = false,
               Cheese = true,
               Peperoni = false,
               tuna = false,
               kebab = false,
               Vege = false,
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="KebabPizza",
               PizzaName="KebabPizza",
               BasePrice=2,
               TomatoSauce = true,
               Cheese = true,
               Peperoni = false,
               tuna = false,
               kebab = true,
               Vege = false,
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="PeperoniPizza",
               PizzaName="PeperoniPizza",
               BasePrice=2,
               TomatoSauce = true,
               Cheese = true,
               Peperoni = true,
               tuna = false,
               kebab = false,
               Vege = false,
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="TunaPizza",
               PizzaName="TunaPizza",
               BasePrice=2,
               TomatoSauce = true,
               Cheese = false,
               Peperoni = false,
               tuna = true,
               kebab = false,
               Vege = false,
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="VegePizza",
               PizzaName="VegePizza",
               BasePrice=2,
               TomatoSauce = true,
               Cheese = false,
               Peperoni = false,
               tuna = false,
               kebab = false,
               Vege = true,
               FinalPrice = 4
           },

        };

        public void OnGet()
        {
        }
    }
}

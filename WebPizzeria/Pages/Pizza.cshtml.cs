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
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="KebabPizza",
               PizzaName="KebabPizza",
               BasePrice=2,
               TomatoSauce = true,
               Cheese = true,
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="KebabPizza",
               PizzaName="KebabPizza",
               BasePrice=2,
               TomatoSauce = true,
               Cheese = true,
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="KebabPizza",
               PizzaName="KebabPizza",
               BasePrice=2,
               TomatoSauce = true,
               Cheese = true,
               FinalPrice = 4
           },
           new PizzasModel ()
           {
               ImageTitle="KebabPizza",
               PizzaName="KebabPizza",
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

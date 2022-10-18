using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebPizzeria.Models;

namespace WebPizzeria.Pages.Forrms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.tuna) PizzaPrice += 1;
            if (Pizza.kebab) PizzaPrice += 1;
            if (Pizza.Vege) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});
        }
    }
}

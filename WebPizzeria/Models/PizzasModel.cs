namespace WebPizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool tuna { get; set; }
        public bool kebab { get; set; }
        public bool Vege { get; set; }
        public float FinalPrice { get; set; }

    }
}


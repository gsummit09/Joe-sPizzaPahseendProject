using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaLib
{
    public class PizzaManagement
    {
        private List<Pizza> pizzas;
        public PizzaManagement()
        {
            pizzas = new List<Pizza>();
        }
        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }
        public List<Pizza>GetPizzas()
        {
            return pizzas;
        }
    }
}

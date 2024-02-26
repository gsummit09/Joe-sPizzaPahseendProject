using NUnit.Framework;
using PizzaLib;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class PizzaSteps
    {
        private PizzaManagement pizzaManagement;
        private Pizza addedPizza;
        [Given(@"the pizza management system is initialized")]
        public void GivenThePizzaManagementIsInitialized()
        {
            
            pizzaManagement = new PizzaManagement();
            //throw new PendingStepException();
        }

        [When(@"a pizza with name ""(.+)"", size (.+), and price (.+) is added")]
        public void WhenAPizzaWithDetailsIsAdded(string name, int size, decimal price)
        {
            addedPizza = new Pizza(name, size, price);
            pizzaManagement.AddPizza(addedPizza);
        }

        [Then(@"the list of pizzas should contain the added pizza")]
        public void ThenTheListOfPizzasShouldContainTheAddedPizza()
        {
            List<Pizza> pizzas = pizzaManagement.GetPizzas();
            Assert.IsTrue(pizzas.Contains(addedPizza));
        }

        // Add more step definitions as needed
    }

}
using Microsoft.AspNetCore.Mvc;
using WebApplicationPizza.Models;

namespace WebApplicationPizza.Controllers
{
    public class PizzaController : Controller
    {
        static public List<Pizza> pizzadetails = new List<Pizza>() {
 new Pizza { PizzaId = 100,Type = "chicago", Price =250, Quantity=2},
 new Pizza { PizzaId = 101,Type = "california",Price=300, Quantity=1},
 new Pizza { PizzaId = 102,Type = "Pepperoni",Price=450, Quantity=1}
 };
        static public List<OrderInfo> orderdetails = new List<OrderInfo>();

        public IActionResult Index()
        {
            return View(pizzadetails);

        }

        [HttpGet]
        public IActionResult create()
        {
            return View(new Pizza());
        }
        [HttpPost]
        public IActionResult Create(Pizza piz)
        {
            if (ModelState.IsValid)
            {
                pizzadetails.Add(piz);
            }
            return RedirectToAction("Index");
        }
        public IActionResult Cart(int id)
        {
            var found = (pizzadetails.Find(p => p.PizzaId == id));
            TempData["id"] = id;
            return View(found);
        }
        [HttpPost]
        public IActionResult Cart(IFormCollection f)
        {
            Random r = new Random();
            int id = Convert.ToInt32(TempData["id"]);
            OrderInfo o = new OrderInfo();
            var found = (pizzadetails.Find(p => p.PizzaId == id));
            o.OrderId = r.Next(100, 999);
            o.PizzaId = id;
            o.Price = found.Price;
            o.Type = found.Type;
            o.Quantity = Convert.ToInt32(Request.Form["qty"]);
            o.TotalPrice = o.Price * o.Quantity;
            orderdetails.Add(o);
            return RedirectToAction("Checkout");

        }
        public IActionResult Checkout()
        {
            //var found = orderdetails.Find(p => p.OrderId == orderid);
            //Console.WriteLine(orderdetails); 
            return View(orderdetails);
        }
    }
}
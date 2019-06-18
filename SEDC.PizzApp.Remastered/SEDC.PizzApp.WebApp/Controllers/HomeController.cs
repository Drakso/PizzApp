using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.PizzApp.Domain;
using SEDC.PizzApp.Services;
using SEDC.PizzApp.WebApp.Models;

namespace SEDC.PizzApp.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IPizzaOrderService _pizzaOrderService;
        public HomeController(IPizzaOrderService pizzaOrderService)
        {
            _pizzaOrderService = pizzaOrderService;
        }
        public IActionResult Index()
        {
            return View(new HomeViewModel());
        }
        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            return RedirectToAction("Order", "Order", new { pizzas = model.NumberOfPizzas });
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Menu()
        {
            List<Pizza> menu = _pizzaOrderService.GetMenu();
            MenuViewModel model = new MenuViewModel()
            {
                Menu = menu
            };
            return View(model);
        }
    }
}

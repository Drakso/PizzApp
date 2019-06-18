using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SEDC.PizzApp.DataAccess.Repositories;
using SEDC.PizzApp.Domain;

namespace SEDC.PizzApp.Services
{
    public class PizzaOrderService : IPizzaOrderService
    {
        private IRepository<Order> _orderRepository;
        private IRepository<Pizza> _pizzaRepository;
        public PizzaOrderService(IRepository<Order> orderRepository, IRepository<Pizza> pizzaRepository)
        {
            _orderRepository = orderRepository;
            _pizzaRepository = pizzaRepository;
        }
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public List<Pizza> GetMenu()
        {
            List<Pizza> menu = _pizzaRepository.GetAll()
                .GroupBy(x => x.Name)
                .Select(x => x.First())
                .ToList();
            return menu;
        }

        public Order GetOrderById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public int GetOrdersCount()
        {
            return _orderRepository.GetAll().Count;
        }

        public void MakeNewOrder(Order order)
        {
            _orderRepository.Insert(order);
        }
        public Pizza GetLastPizzaOrdered()
        {
            List<Order> orders = _orderRepository.GetAll();
            Order lastOrder = orders[orders.Count - 1];
            return lastOrder.Pizzas[lastOrder.Pizzas.Count - 1];
        }
        public string GetMostPopularPizza()
        {
            List<Order> orders = _orderRepository.GetAll();
            List<Pizza> pizzas = orders.SelectMany(x => x.Pizzas).ToList();
            string mostPopularPizza = pizzas
            .GroupBy(x => x.Name)
            .OrderByDescending(x => x.Count())
            .FirstOrDefault()
            .Select(x => x.Name)
            .FirstOrDefault();
            return mostPopularPizza;
        }
        public Pizza GetPizzaById(int id)
        {
            return _pizzaRepository.GetById(id);
        }
    }
}

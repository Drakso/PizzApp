using SEDC.PizzApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzApp.Services
{
    public interface IPizzaOrderService
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        Pizza GetPizzaById(int id);
        int GetOrdersCount();
        List<Pizza> GetMenu();
        void MakeNewOrder(Order order);
        Pizza GetLastPizzaOrdered();
        string GetMostPopularPizza();
    }
}

using SEDC.PizzApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzApp.DataAccess.Repositories.ListRepositories
{
    public class OrderRepository : IRepository<Order>
    {
        public void DeleteById(int id)
        {
            Order order = ListDb.Orders.FirstOrDefault(x => x.Id == id);
            if (order != null) ListDb.Orders.Remove(order);
        }

        public List<Order> GetAll()
        {
            return ListDb.Orders;
        }

        public Order GetById(int id)
        {
            return ListDb.Orders.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Order entity)
        {
            ListDb.OrderId++;
            entity.Id = ListDb.OrderId;
            ListDb.Orders.Add(entity);
        }

        public void Update(Order entity)
        {
            Order order = ListDb.Orders.FirstOrDefault(x => x.Id == entity.Id);
            if (order != null)
            {
                int index = ListDb.Orders.IndexOf(order);
                ListDb.Orders[index] = entity;
            }
        }
    }
}

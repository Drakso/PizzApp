using SEDC.PizzApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzApp.DataAccess.Repositories.ListRepositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        public void DeleteById(int id)
        {
            Pizza pizza = ListDb.Menu.FirstOrDefault(x => x.Id == id);
            if (pizza != null) ListDb.Menu.Remove(pizza);
        }

        public List<Pizza> GetAll()
        {
            return ListDb.Menu;
        }

        public Pizza GetById(int id)
        {
            return ListDb.Menu.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Pizza entity)
        {
            ListDb.PizzaId++;
            entity.Id = ListDb.PizzaId;
            ListDb.Menu.Add(entity);
        }

        public void Update(Pizza entity)
        {
            Pizza pizza = ListDb.Menu.FirstOrDefault(x => x.Id == entity.Id);
            if (pizza != null)
            {
                int index = ListDb.Menu.IndexOf(pizza);
                ListDb.Menu[index] = entity;
            }
        }
    }
}

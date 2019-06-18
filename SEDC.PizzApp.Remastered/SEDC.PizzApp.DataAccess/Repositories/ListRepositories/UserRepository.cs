using SEDC.PizzApp.Domain;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzApp.DataAccess.Repositories.ListRepositories
{
    public class UserRepository : IRepository<User>
    {
        public void DeleteById(int id)
        {
            User user = ListDb.Users.FirstOrDefault(x => x.Id == id);
            if (user != null) ListDb.Users.Remove(user);
        }

        public List<User> GetAll()
        {
            return ListDb.Users;
        }

        public User GetById(int id)
        {
            return ListDb.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(User entity)
        {
            ListDb.UserId++;
            entity.Id = ListDb.UserId;
            ListDb.Users.Add(entity);
        }

        public void Update(User entity)
        {
            User user = ListDb.Users.FirstOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                int index = ListDb.Users.IndexOf(user);
                ListDb.Users[index] = entity;
            }
        }
    }
}

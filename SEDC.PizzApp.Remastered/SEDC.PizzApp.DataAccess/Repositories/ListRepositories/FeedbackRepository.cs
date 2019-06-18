using SEDC.PizzApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzApp.DataAccess.Repositories.ListRepositories
{
    public class FeedbackRepository : IRepository<Feedback>
    {
        public void DeleteById(int id)
        {
            Feedback feedback = ListDb.Feedbacks.FirstOrDefault(x => x.Id == id);
            if (feedback != null) ListDb.Feedbacks.Remove(feedback);
        }

        public List<Feedback> GetAll()
        {
            return ListDb.Feedbacks;
        }

        public Feedback GetById(int id)
        {
            return ListDb.Feedbacks.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Feedback entity)
        {
            ListDb.FeedbackId++;
            entity.Id = ListDb.FeedbackId;
            ListDb.Feedbacks.Add(entity);
        }

        public void Update(Feedback entity)
        {
            Feedback feedback = ListDb.Feedbacks.FirstOrDefault(x => x.Id == entity.Id);
            if (feedback != null)
            {
                int index = ListDb.Feedbacks.IndexOf(feedback);
                ListDb.Feedbacks[index] = entity;
            }
        }
    }
}

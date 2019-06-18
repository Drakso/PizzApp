using SEDC.PizzApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzApp.Services
{
    public interface IUserService
    {
        void RegisterUser(User user);
        User GetUserById(int id);
        void GiveFeedback(Feedback feedback);
        List<Feedback> GetFeedback(int numberOfFeedbackUnits);
        User GetLastUser();
    }
}

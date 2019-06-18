using System;
using System.Collections.Generic;
using System.Text;
using SEDC.PizzApp.DataAccess.Repositories;
using SEDC.PizzApp.Domain;

namespace SEDC.PizzApp.Services
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private IRepository<Feedback> _feedbackRepository;
        public UserService(IRepository<User> userRepository, IRepository<Feedback> feedbackRepository)
        {
            _userRepository = userRepository;
            _feedbackRepository = feedbackRepository;
        }
        public List<Feedback> GetFeedback(int numberOfFeedbackUnits)
        {
            return _feedbackRepository.GetAll().GetRange(0, numberOfFeedbackUnits);
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void GiveFeedback(Feedback feedback)
        {
            _feedbackRepository.Insert(feedback);
        }

        public void RegisterUser(User user)
        {
            _userRepository.Insert(user);
        }
        public User GetLastUser()
        {
            List<User> users = _userRepository.GetAll();
            return users[users.Count - 1];
        }
    }
}

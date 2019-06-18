using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SEDC.PizzApp.DataAccess.Repositories;
using SEDC.PizzApp.DataAccess.Repositories.ListRepositories;
using SEDC.PizzApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzApp.Services.Helpers
{
    public static class DIRepositoryModule
    {
        // Dependency Injection module
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Feedback>, FeedbackRepository>();
            services.AddTransient<IRepository<Order>, OrderRepository>();
            services.AddTransient<IRepository<Pizza>, PizzaRepository>();

            return services;
        }
    }
}

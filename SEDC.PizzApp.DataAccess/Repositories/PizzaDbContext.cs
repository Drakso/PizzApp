using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzApp.DataAccess.Repositories
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions options)
            : base(options) { }
    }
}

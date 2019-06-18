using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzApp.WebApp.Models
{
    public class OrderDetailsViewModel
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public OrderItemViewModel Order { get; set; }
    }
}

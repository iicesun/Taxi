using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taxi.Models
{
    public class CreateOrderModel
    {
        public Order Order { get; set; }
        public List<Automobile> Automobiles { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
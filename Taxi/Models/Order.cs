using System;
using Taxi.Models;

namespace Taxi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int PlaneLong { get; set; }
        public int FactLong { get; set; }
        public Customer Customer { get; set; }
        public Automobile Automobile { get; set; }
        public int Cost { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Taxi.Models;

namespace Taxi.Service
{
    public class InitializationDateBaseTaxi
    {
        public List<Automobile> Automobiles { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Order> Orders { get; set; }

        public InitializationDateBaseTaxi()
        {
            Automobiles = new List<Automobile>();
            Customers = new List<Customer>();
            Orders = new List<Order>();

            InitializationAutomobilesList();
            InitializationCustomersList();
            InitializationOrdersList(Automobiles, Customers);
        }

        private void InitializationAutomobilesList()
        {

            Automobiles.Add(new Automobile()
            {
                Id = 1,
                CarBrand = "BMW",
                Collor = "Black",
                YearMake = "2014",
                Mileage = 100000
            });
            Automobiles.Add(new Automobile()
            {
                Id = 2,
                CarBrand = "BMW",
                Collor = "White",
                YearMake = "2013",
                Mileage = 100
            });
            Automobiles.Add(new Automobile()
            {
                Id = 3,
                CarBrand = "Shkoda",
                Collor = "Blue",
                YearMake = "2012",
                Mileage = 1050
            });
            Automobiles.Add(new Automobile()
            {
                Id = 4,
                CarBrand = "Lada",
                Collor = "Black",
                YearMake = "2014",
                Mileage = 10
            });
            Automobiles.Add(new Automobile()
            {
                Id = 5,
                CarBrand = "Toyota",
                Collor = "Red",
                YearMake = "2014",
                Mileage = 100
            });
        }

        private void InitializationCustomersList()
        {
            Customers.Add(new Customer() { Id = 1, Lastname = "Ivanov", Name = "Ivan" });
            Customers.Add(new Customer() { Id = 2, Lastname = "Petrov", Name = "Peter" });
            Customers.Add(new Customer() { Id = 3, Lastname = "Alexandrov", Name = "Alexander" });
        }

        private void InitializationOrdersList(List<Automobile> automobiles, List<Customer> customers)
        {
            Orders.Add(new Order()
            {
                Id = 1,
                DateTime = new DateTime(2014, 07, 19, 16, 20, 00),
                PlaneLong = 60,
                Customer = customers.First(customer => customer.Id == 1),
                Cost = 325,
                Automobile = automobiles.First(automobile => automobile.Id == 2)
            });
            Orders.Add(new Order()
            {
                Id = 2,
                DateTime = new DateTime(2014, 07, 19, 16, 30, 00),
                PlaneLong = 60,
                Customer = customers.First(customer => customer.Id == 2),
                Cost = 325,
                Automobile = automobiles.First(automobile => automobile.Id == 1)
            });
            Orders.Add(new Order()
            {
                Id = 3,
                DateTime = new DateTime(2014, 07, 19, 15, 20, 00),
                PlaneLong = 60,
                Customer = customers.First(customer => customer.Id == 3),
                Cost = 325,
                Automobile = automobiles.First(automobile => automobile.Id == 3)
            });
            Orders.Add(new Order()
            {
                Id = 4,
                DateTime = new DateTime(2014, 07, 19, 18, 20, 00),
                PlaneLong = 60,
                Customer = customers.First(customer => customer.Id == 3),
                Cost = 325,
                Automobile = automobiles.First(automobile => automobile.Id == 1)
            });
        }


    }
}
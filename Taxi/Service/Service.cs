using System;
using System.Collections.Generic;
using Taxi.Models;

namespace Taxi.Service
{
    public class TaxiService
    {
        private InitializationDateBaseTaxi dbTaxi;

        public TaxiService()
        {
            dbTaxi = new InitializationDateBaseTaxi();
        }
        /// <summary>
        /// Возвращает Список автомобилей
        /// </summary>
        /// <returns>Список автомобилей</returns>
        public List<Automobile> GetAutomobileCollection()
        {
            return dbTaxi.Automobiles;
        }

        public List<Customer> GetCustomers()
        {
            return dbTaxi.Customers;
        }

        public List<Order> GetOrdersAutomobile(Automobile automobile)
        {
            return dbTaxi.Orders;
        }
    }
}
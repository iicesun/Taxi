using System;
using System.Collections.Generic;
using Taxi.Models;

namespace Taxi.Service
{
    public class TaxiService: ITaxiService
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

        /// <summary>
        /// Возвращает список пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        public List<Customer> GetCustomers()
        {
            return dbTaxi.Customers;
        }

        /// <summary>
        /// Возвращает список заказов у автомобиля
        /// </summary>
        /// <param name="automobile">автомобиль</param>
        /// <returns>Список заказов у автомобиля</returns>
        public List<Order> GetOrdersAutomobile(Automobile automobile)
        {
            return dbTaxi.Orders;
        }

        public void SetOrdersAutomobile(Order order)
        {
            dbTaxi.Orders.Add(order);
        }
    }

    public interface ITaxiService
    {
        /// <summary>
        /// Возвращает Список автомобилей
        /// </summary>
        /// <returns>Список автомобилей</returns>
        List<Automobile> GetAutomobileCollection();

        /// <summary>
        /// Возвращает список пользователей
        /// </summary>
        /// <returns>Список пользователей</returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Возвращает список заказов у автомобиля
        /// </summary>
        /// <param name="automobile">автомобиль</param>
        /// <returns>Список заказов у автомобиля</returns>
        List<Order> GetOrdersAutomobile(Automobile automobile);

        void SetOrdersAutomobile(Order order)
    }
}
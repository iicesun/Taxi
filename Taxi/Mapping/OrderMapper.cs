using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Taxi.Models;

namespace Taxi.Mapping
{
    public class OrderMapper: IMapper
    {
        public OrderMapper()
        {
            CreateOrderModelToOrderMapper();
        }

        public Order CreateOrderModelToOrderMapper(CreateOrderModel createOrderModel)
        {
            Mapper.RegisterMapper<CreateOrderModel, Order>();
            var order = new Order();
            order.Automobile = createOrderModel.Order.Automobile;
            order.Cost = createOrderModel.Order.Cost;
            order.Customer = createOrderModel.Order.Customer;
            order.DateTime = createOrderModel.Order.DateTime;
            order.FactLong = createOrderModel.Order.FactLong;
            order.Id = createOrderModel.Order.Id;
            order.PlaneLong = createOrderModel.Order.PlaneLong;
            return order;
        }

    }
}
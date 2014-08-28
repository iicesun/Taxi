using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taxi.Helpers;
using Taxi.Models;
using Taxi.Service;

namespace Taxi.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Document/
        private readonly ITaxiService taxiService;

        public OrdersController()
        {
            taxiService = ServiceLocator.ServiceLocatorPropertes.GetService<ITaxiService>();
        }

        public ActionResult CreateOrder()
        {
            var model = new CreateOrderModel();
            model.Automobiles = taxiService.GetAutomobileCollection();
            model.Customers =  taxiService.GetCustomers();
            return View(model);
        }

        [HttpPost]
        public ActionResult CreateOrder(CreateOrderModel createOrderModel)
        {
            taxiService.SetOrdersAutomobile();
            return Redirect(Url.Action("Orders", "Home", new {Id = 1}));
        }
    }
}

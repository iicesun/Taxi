using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Taxi.Models;
using Taxi.Service;

namespace Taxi.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Document/
        private TaxiService taxiService;

        public OrdersController()
        {
            taxiService = new TaxiService();
        }

        public ActionResult CreateOrder()
        {
            var model = new CreateOrderModel();
            model.Automobiles = taxiService.GetAutomobileCollection();
            model.Customers = taxiService.GetCustomers();
            return View(model);
        }

       /* [HttpPost]
        public ActionResult CreateOrder(Order order)
        {
            
        }
*/
    }
}

using System.Web.Mvc;

namespace Taxi.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Main()
        {
            return View();
        }

    }
}

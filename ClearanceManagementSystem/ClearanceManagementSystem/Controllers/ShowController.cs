using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClearanceManagementSystem.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        public ActionResult Index()
        {
            return View();
        }
    }
}


namespace ClearanceManagementSystem.DTO {
    public class SHOW
    {

        public int id { get; set; }
        public string Name { get; set; }

        public string Note { get; set; }
    }

}

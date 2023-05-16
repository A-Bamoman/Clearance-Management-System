using ClearanceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClearanceManagementSystem.Controllers
{
    public class OrderStudentShowController : Controller
    {
        private readonly CMS _cms = new CMS();
        // GET: OrderStudentShow
        public ActionResult OrderStudentShow(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }
        [HttpPost]
        public ActionResult Verify(int id)
        {
           Student_T clearance = _cms.Student_T.FirstOrDefault(x=>x.Student_Number==id);
            
            if (clearance != null)
            {


                return RedirectToAction("StudentShow", "StudentShow", new {id = clearance.ID_Student });
            }
            else
            {
                return RedirectToAction("OrderStudentShow", new { message = "تحقق من كتابة رقم قيدك بالطريقة الصحيحة" });
               
            }
            
        }
        
    }
}
using ClearanceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClearanceManagementSystem.Controllers
{
    public class OrderController : Controller
    {
        private readonly CMS _cms = new CMS();
        // GET: Order
        public ActionResult StudentOrder(string message="")
        {
            ViewBag.Message = message;
            return View();
        }
        [HttpPost]
        public ActionResult ShowOrder(Student_T _sh)
        {
            Student_T clearance = _cms.Student_T.FirstOrDefault(data => data.Student_Name == _sh.Student_Name && data.Student_Number == _sh.Student_Number && data.College == _sh.College);
            if(clearance!=null)
            {
                Orderss_T u = _cms.Orderss_T.FirstOrDefault(r => r.ID_Student == clearance.ID_Student);

                if (u==null)
                {
                    int stuID = clearance.ID_Student;

                    foreach (var item in _cms.User_T.ToList())
                    {
                        _cms.Orderss_T.Add(new Orderss_T
                        {
                            ID_Student = stuID,
                            ID_User = item.ID_User
                        });
                    }
                }
                else
                {
                    //ViewBag.Message = "ighg";
                    return RedirectToAction("StudentOrder",new { message= "لقد تم ارسال الطلب بهذا الحساب سابقا" });
                }
                 _cms.SaveChanges();
                return RedirectToAction("StudentOrder", new { message = "تم ارسال طلبك بنجاح يرجى مراجعة طلبك  خلال اسبوع" });


            }
            else
            {
                return RedirectToAction("StudentOrder", new { message = "تأكد من ادخال البيانات بشكل صحيح" });
            }


        } 
        class addStudentID
        {
            public int IDStudent { get; set; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClearanceManagementSystem.Models;
using System.Data.SqlClient;

namespace CMSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly CMS _cms = new CMS();
        //public ActionResult vi(Account ac)
        //{
        //    var u = _cms.User_T.FirstOrDefault(data => data.UserName == ac.UserName && data.Password == ac.Password);

        //    if (u != null)
        //    {

        //        var stuListData = _cms.Orderss_T.Where(data => data.ID_Student == ac.Password).ToList();


        //    //    List<StudentShowData> listData = new List<StudentShowData>();
        //    //    foreach (var row in stuListData)
        //    //    {
        //    //        listData.Add(new StudentShowData
        //    //        {
        //    //            Dept = _cms.User_T.FirstOrDefault(d => d.ID_User == row.ID_User).Name_Office,
        //    //            Done = row.Status,
        //    //            Notes = row.Notes

        //    //        });


        //    //    }
        //    //}


        //   // _cms.Orders_T.Add(new Orders_T
        //    //{
        //      //  Notes = ""
        //   // });

            


        //    return null;
        //}

        class StudentShowData
        {
            public string Dept { get; set; }
            public bool? Done { get; set; }
            public string Notes { get; set; }
            
        }


        public ActionResult Login(string message = "")
        {
            ViewBag.Message = message;
            return View();
        }
      
        [HttpPost]

        public ActionResult Varify(User_T _user)
        {

            User_T user = _cms.User_T.FirstOrDefault(u => u.UserName == _user.UserName && u.Password == _user.Password);
            if (user != null)
            {
                return RedirectToAction("Show","UserShow" , new {id = user.ID_User });
            }

            else
            {
                return RedirectToAction("Login", new { message = "تأكد من ادخال البيانات بشكل صحيح" });
            }

        }




        // GET: Login

        //public ActionResult Login()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Verify(Account acc)
        //{
        //    connectionString();
        //    con.Open();
        //    com.Connection = con;
        //    com.CommandText = "select * from loginT where Name='" + acc.Name + "' and Password ='" + acc.Password + "'";
        //    dr = com.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        con.Close();

        //        return View("create");
        //    }
        //    else
        //    {
        //        con.Close();

        //        return View("error");
        //    }

        //}
    }
}
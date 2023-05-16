using ClearanceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClearanceManagementSystem.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly CMS _cms = new CMS();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Show()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Verify(Show show)
        {
           
            var StatusListData = _cms.Orderss_T.Where(data => data.ID_Student == show.ID_Student).ToList();


            List<StudentShowData> listData = new List<StudentShowData>();
            foreach (var row in StatusListData)
            {
                listData.Add(new StudentShowData
                {
                    Dept = _cms.User_T.FirstOrDefault(d => d.ID_User == row.ID_User).Name_Office,
                    Done = row.Status,
                    Notes = row.Notes

                });
            }
            return View("Show");
        }

        class StudentShowData
        {
            public string Dept { get; set; }
            public bool? Done { get; set; }
            public string Notes { get; set; }
        }
    
    }
}
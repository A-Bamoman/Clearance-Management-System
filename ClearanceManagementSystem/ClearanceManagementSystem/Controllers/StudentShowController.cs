using ClearanceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClearanceManagementSystem.Controllers;


namespace ClearanceManagementSystem.Controllers
{

    public class StudentShowController : Controller
    {
        private readonly CMS _cms = new CMS();

        // GET: StudentShow
      
        public ActionResult StudentShow(int id)
        {
            var stuListData = _cms.Orderss_T.Where(data => data.ID_Student == id).ToList();


            List<StudentShowData> ListData = new List<StudentShowData>();
            foreach (var row in stuListData)
            {
                ListData.Add(new StudentShowData
                {
                    Dept = _cms.User_T.FirstOrDefault(d => d.ID_User == row.ID_User).Name_Office,
                    Done = row.Status,
                    Notes = row.Notes,

                });
                //return View (null);

            }

       

            return View(ListData);
        }

        private ActionResult View(Func<ActionResult> studentShow)
        {
            throw new NotImplementedException();
        }

        public class StudentShowData
        {
            public string Dept { get; set; }
            public bool? Done { get; set; }
            public string Notes { get; set; }

        }
            
        
    }
}
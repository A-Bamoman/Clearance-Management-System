using ClearanceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ClearanceManagementSystem.Controllers
{
    public class UserShowController : Controller
    {
        // GET: UserShow
        private readonly CMS _cms = new CMS();
        public ActionResult UserShow()
        {
            return View();
        }

        public ActionResult Show(int id)
        {
            var stuListData = _cms.Orderss_T.Where(data => data.Status == null && data.ID_User == id).ToList();


            List<UserShowData> listData = new List<UserShowData>();
            foreach (var row in stuListData)
            {
                listData.Add(new UserShowData
                {
                    STUNU = _cms.Student_T.FirstOrDefault(d => d.ID_Student == row.ID_Student).Student_Number,
                    STUNA = _cms.Student_T.FirstOrDefault(d => d.ID_Student == row.ID_Student).Student_Name,
                    COLLEGE = _cms.Student_T.FirstOrDefault(d => d.ID_Student == row.ID_Student).College,
                    idu = row.ID_Order,

                });

            }

            return View(listData);
        }

        public ActionResult Editt(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orderss_T task = _cms.Orderss_T.Find(id);
            if (task == null)
            {
                return HttpNotFound();
            }
            return View(task);
        }

        //// POST: Tasks/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editt(Orderss_T task)
        {
            if (ModelState.IsValid)
            {
                _cms.Entry(task).State = EntityState.Modified;
                _cms.SaveChanges();
                return RedirectToAction("Show",new { id = task.ID_User});
            }
            return View(task);
        }


        public class UserShowData
        {
            public int STUNU { get; set; }
            public string STUNA { get; set; }
            public string COLLEGE { get; set; }
            public int idu { get; set; }

        }
    }
    
}
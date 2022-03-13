using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirstDemo.Models;
using EFCodeFirstDemo.Migrations;
using System.Data.Entity;


namespace EFCodeFirstDemo.Controllers
{
    public class StudentController : Controller
    {

        PGDACContext db=new PGDACContext();//creating DBContext object for db operations
        // GET: Student
        public ActionResult Index()
        {
            //select * from table
            //return View(db.Students.ToList());
            return View(db.Students.Include("Address").ToList());
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        //insert Code to save student data
        [HttpPost]
        public ActionResult Create(Student student)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PGDACContext,Configuration>());

          //  Database.SetInitializer(new DropCreateDatabaseAlways<PGDACContext>()); //Don't use this command otherwisw all data will be deleted
            if(ModelState.IsValid)
            {
                db.Students.Add(student);//Adding current entity in context
                db.SaveChanges();//saving in data base
               // ViewBag.Message = "Student Data Saved Successfully";
                return RedirectToAction("Index");
            }
            return View(student);
            
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KuVenkatCheckBox.Models;


namespace KuVenkatCheckBox.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            EmployeDataModel db = new EmployeDataModel();
            var emp= db.Employees.Single(x => x.Id == id);

            ViewData["EmployeeData"] = emp;

            return View();
            //return View(emp);
        }

        public ActionResult List()
        {
            Company company = new Company();

            return View(company);

        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeDataModel db = new EmployeDataModel();
            var emp = db.Employees.Single(x => x.Id == id);

            return View(emp);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                 if(ModelState.IsValid)
                {
                    EmployeDataModel db = new EmployeDataModel();
                    var emp = db.Employees.Single(x => x.Id == employee.Id);

                    emp.FullName = employee.FullName;
                    emp.Gender = employee.Gender;

                    db.SaveChanges();
                }
                return RedirectToAction("Details",new { id = employee.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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

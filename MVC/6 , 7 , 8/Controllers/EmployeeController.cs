﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _6.Models;

namespace _6.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {


           
            /*Employee employee = new Employee()
            {
                Id = 101,
                Name = "John",
                Gender = "Male",
                Email = "john@legend.com"
            };*/

            //return View();

            //this code is for video 8
            EmployeeContext emp1 = new EmployeeContext();
            Employee employee = emp1.Employees.Single(emp => emp.Id == id); 
            return View(employee);
            //return View();
        }

        public ActionResult Index()
        {
            ViewData["YourData"] = "ViewData";
            ViewBag.MyData = "ViewBag";

            return View();
        }
    }
}
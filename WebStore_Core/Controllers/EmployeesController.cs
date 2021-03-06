﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_Core.Data;
using WebStore_Core.Models;

namespace WebStore_Core.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly List<Employee> _Employees;
        public EmployeesController() => _Employees = TestData.Employees;
        public IActionResult Index() => View(_Employees);

        public IActionResult Details(int id)
        {
            var employee = _Employees.FirstOrDefault(e => e.Id == id);
            if(employee is not null)
                return View(employee);
            return NotFound();
        }

    }
}

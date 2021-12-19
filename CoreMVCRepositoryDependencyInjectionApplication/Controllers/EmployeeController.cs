using CoreMVCRepositoryDependencyInjectionApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCRepositoryDependencyInjectionApplication.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        public IActionResult Index()
        { 
            return View(employeeRepository.GetEmployees());
        }

        public IActionResult Details(int id)
        {
            return View(employeeRepository.GetEmployeeById(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employeeRepository.AddEmplyee(employee);

            return RedirectToAction("Index");
        }
    }
}

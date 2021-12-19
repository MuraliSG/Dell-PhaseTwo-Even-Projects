using ConfiguringMVCApplications.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringMVCApplications.controllers
{
    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>()
        {
            new Student(){StudentID=101, Name="King Kochhar", Gender="Male", City="Delhi"},
            new Student(){StudentID=102, Name="John Smith", Gender="Male", City="Mumbai"},
            new Student(){StudentID=103, Name="Sarah Bowling", Gender="Female", City="Mumbai"},
            new Student(){StudentID=104, Name="Roger lee", Gender="Male", City="Delhi"},
            new Student(){StudentID=105, Name="Shreya Kalyan", Gender="Female", City="Mumbai"}
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Manage Students";
            ViewBag.StudentCount = students.Count;
            ViewBag.StudentList = students;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using System.Reflection;

namespace StudentMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        // AmtPaid being set to $0
        public IActionResult Index()
        {
            ViewBag.AmtPaid = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(FinalProject.Models.StudentWorkerModel student)
        {   
            // Method connecting with view of AmtPaid in order to display
            student.WeeklySalary();
            ViewBag.AmtPaid = student.WeeklySalary();
            return View(student);
        }

    }
}

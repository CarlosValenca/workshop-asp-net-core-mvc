using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> dept = new List<Department>();
            dept.Add(new Department { Id = 1, Name = "Eletronics" });
            dept.Add(new Department { Id = 2, Name = "Fashion" });
            return View(dept);
        }
    }
}
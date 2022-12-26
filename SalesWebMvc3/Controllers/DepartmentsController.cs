using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMvc3.Models;
using System;

namespace SalesWebMvc3.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Departments> list = new List<Departments>();
            list.Add(new Departments { Id = 1, Name = "Eletronics" });
            list.Add(new Departments { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}

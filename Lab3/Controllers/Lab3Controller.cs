using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class Lab3Controller : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FormModel model)
        {

            if (ModelState.IsValid)
            {
                return View("Created", model);
            }
            return View(model);
        }

    }
}

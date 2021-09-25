using Microsoft.AspNetCore.Mvc;
using Precencial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Precencial.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CamposViewModel campos)
        {
            if (!ModelState.IsValid)
            {
                return View("Index",campos);
            }
            else
            {
                return RedirectToAction("Exito");
            }
            
        }
        public IActionResult Exito()
        {
            return View();
        }
    }
}

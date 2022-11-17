using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_semana_16.Controllers
{
    public class PracticaPrograController : Controller
    {
        public IActionResult Paramethers(string empresaName, string propietarioName)
        {
            ViewData["empresa"] = empresaName;
            ViewData["Name"] = "Hola " + propietarioName + " eres el dueño de la empresa:" + empresaName;
            return View();
        }
    }
}

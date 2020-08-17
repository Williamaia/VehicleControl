using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleControl.Models; 

namespace VehicleControl.Controllers
{
    public class MarcasController : Controller
    {
        public IActionResult Index()
        {
            List<Marca> list = new List<Marca>();
            list.Add(new Marca { id = 1, name = "Honda" });
            list.Add(new Marca { id = 2, name = "Fiat" });

            return View(list);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VehicleControl.Controllers
{
    public class ModelosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
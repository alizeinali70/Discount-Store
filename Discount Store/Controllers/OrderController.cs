﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount_Store.Controllers
{
    public class OrderController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

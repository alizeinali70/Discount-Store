using Discount_Store.Interfaces;
using Discount_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount_Store.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartService _cartService;

        public OrderController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            TempData["GetTotal"] = GetTotal();
            findall();
            return View();
        }
        public IActionResult Add(Item item)
        {
            _cartService.Add(item);
            TempData["GetTotal"] = GetTotal();
            return View("Index");
            //return Redirect(nameof(Index));
        }
        public IActionResult Remove(Item item)
        {
            _cartService.Remove(item);
            TempData["GetTotal"] = GetTotal();
            return View("Index");
        }
        public float GetTotal()
        {
            float t = _cartService.GetTotal();
            return t;
        }
       
    }
}

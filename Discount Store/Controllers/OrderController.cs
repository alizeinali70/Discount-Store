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
            return View();
        }
        public IActionResult Add(Item item)
        {
            _cartService.Add(item);
            return View("Index");
        }
    }
}

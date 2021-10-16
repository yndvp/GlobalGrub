﻿using GlobalGrub.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGrub.Controllers
{
    public class ShopController : Controller
    {
        // add DbContext to use the database
        private readonly ApplicationDbContext _context;

        // constructor that takes an instance of our db connection
        public ShopController(ApplicationDbContext context)
        {
            _context = context; // assign incoming db connection so we can use it in any method in this controller
        }

        public IActionResult Index()
        {
            // use Categories DbSet to fetch list of categories to display to shoppers
            var categories = _context.Categories.OrderBy(c => c.Name).ToList();

            return View(categories);
        }
    }
}

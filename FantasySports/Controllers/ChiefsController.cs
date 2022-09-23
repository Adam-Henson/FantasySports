﻿using Microsoft.AspNetCore.Mvc;
using CRUDApp.Context;
using FantasySports.Models;
using CRUDApp.Models;

namespace FantasySports.Controllers
{
    public class ChiefsController : Controller
    {
        private readonly FantasySportsContext _context;
        public ChiefsController(FantasySportsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ChiefsViewModel model = new ChiefsViewModel(_context);
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int teamId, int? week1Score, int? week2Score, int? week3Score, int? week4Score, int? week5Score, int? week6Score, int? week7Score, int? week8Score, int? week9Score, int? week10Score, int? week11Score, int? week12Score, int? week13Score, int? week14Score, int? week15Score, int? week16Score, int? week17Score, int? week18Score)
        {
            ChiefsViewModel model = new ChiefsViewModel(_context);
            Chiefs football = new(teamId, week1Score, week2Score, week3Score, week4Score, week5Score, week6Score, week7Score, week8Score, week9Score, week10Score, week11Score, week12Score, week13Score, week14Score, week15Score, week16Score, week17Score, week18Score);

            return View(model);
        }
    }
}

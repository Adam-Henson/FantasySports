using Microsoft.AspNetCore.Mvc;
using CRUDApp.Context;
using FantasySports.Models;
using CRUDApp.Models;

namespace FantasySports.Controllers
{
    public class MergeModelController : Controller
    {
        private readonly FantasySportsContext _context;
        public MergeModelController(FantasySportsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            MergeModelViewModel model = new MergeModelViewModel(_context);


            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int teamId, int? week1Score, int? week2Score, int? week3Score, int? week4Score, int? week5Score, int? week6Score, int? week7Score, int? week8Score, int? week9Score, int? week10Score, int? week11Score, int? week12Score, int? week13Score, int? week14Score, int? week15Score, int? week16Score, int? week17Score, int? week18Score)
        {
            MergeModelViewModel model = new MergeModelViewModel(_context);

            return View(model);
        }
        public IActionResult FantasyGame()
        {
            MergeModelViewModel model = new MergeModelViewModel(_context);

            return View(model);
        }

        public IActionResult week7through12()
        {
            MergeModelViewModel model = new MergeModelViewModel(_context);

            return View(model);
        }

        public IActionResult week13through18()
        {
            MergeModelViewModel model = new MergeModelViewModel(_context);

            return View(model);
        }

        public IActionResult Points()
        {
            MergeModelViewModel model = new MergeModelViewModel(_context);

            model.GetPoints();

            return View("FantasyGame", model);
        }

    }
}
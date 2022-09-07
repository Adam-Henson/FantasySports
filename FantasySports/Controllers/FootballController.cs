using Microsoft.AspNetCore.Mvc;
using CRUDApp.Models;
using System;
using System.Linq;
using CRUDApp.Context;
using FantasySports.Models;

namespace FantasySports.Controllers
{
    public class FootballController : Controller
    {
        private readonly FantasySportsContext _context;
        public FootballController(FantasySportsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            FootballViewModel model = new FootballViewModel(_context);
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int teamID, string versus, int totalPoints, string seasonRecord)
        {
            FootballViewModel model = new FootballViewModel(_context);
            Football football = new(teamID, versus, totalPoints, seasonRecord);

            model.SaveTeam(football);
            model.IsActionSuccess = true;
            model.ActionMessage = "Team has been saved successfully";

            return View(model);
        }
        public IActionResult Update(int id)
        {
            FootballViewModel model = new FootballViewModel(_context, id);
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            FootballViewModel model = new FootballViewModel(_context, id);

            if (id > 0)
            {
                model.RemoveTeam(id);
            }

            model.IsActionSuccess = true;
            model.ActionMessage = "Team has been deleted successfully";
            return View("Index", model);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using CRUDApp.Models;
using System;
using System.Linq;
using CRUDApp.Context;
using FantasySports.Models;

namespace FantasySports.Controllers
{
    public class ArizonaCardinalsController : Controller
    {
        private readonly FantasySportsContext _context;
        public ArizonaCardinalsController(FantasySportsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ArizonaCardinalsViewModel model = new ArizonaCardinalsViewModel(_context);
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(int teamID, string myTeam, string versus, string score, string seasonRecord)
        {
            ArizonaCardinalsViewModel model = new ArizonaCardinalsViewModel(_context);
            ArizonaCardinals football = new(teamID, myTeam, versus, score, seasonRecord);

            model.SaveTeam(football);
            model.IsActionSuccess = true;
            model.ActionMessage = "Team has been saved successfully";

            return View(model);
        }
        public IActionResult Update(int id)
        {
            ArizonaCardinalsViewModel model = new ArizonaCardinalsViewModel(_context, id);
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            ArizonaCardinalsViewModel model = new ArizonaCardinalsViewModel(_context, id);

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

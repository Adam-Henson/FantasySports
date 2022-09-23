using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class _49ErsViewModel
    {
        private _49ErsRepository _repo;
        public List<_49Ers> TeamList { get; set; }
        public _49Ers CurrentTeam { get; set; }
        public _49ErsViewModel(FantasySportsContext context)
        {
            _repo = new _49ErsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public _49ErsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new _49ErsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new _49Ers();
            }
        }
        public List<_49Ers> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public _49Ers GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

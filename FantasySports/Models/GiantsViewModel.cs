using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class GiantsViewModel
    {
        private GiantsRepository _repo;
        public List<Giants> TeamList { get; set; }
        public Giants CurrentTeam { get; set; }
        public GiantsViewModel(FantasySportsContext context)
        {
            _repo = new GiantsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public GiantsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new GiantsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Giants();
            }
        }
        public List<Giants> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Giants GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

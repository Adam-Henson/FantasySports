using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class SaintsViewModel
    {
        private SaintsRepository _repo;
        public List<Saints> TeamList { get; set; }
        public Saints CurrentTeam { get; set; }
        public SaintsViewModel(FantasySportsContext context)
        {
            _repo = new SaintsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public SaintsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new SaintsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Saints();
            }
        }
        public List<Saints> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Saints GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class PatriotsViewModel
    {
        private PatriotsRepository _repo;
        public List<Patriots> TeamList { get; set; }
        public Patriots CurrentTeam { get; set; }
        public PatriotsViewModel(FantasySportsContext context)
        {
            _repo = new PatriotsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public PatriotsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new PatriotsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Patriots();
            }
        }
        public List<Patriots> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Patriots GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class FalconsViewModel
    {
        private FalconsRepository _repo;
        public List<Falcons> TeamList { get; set; }
        public Falcons CurrentTeam { get; set; }
        public FalconsViewModel(FantasySportsContext context)
        {
            _repo = new FalconsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public FalconsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new FalconsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Falcons();
            }
        }
        public List<Falcons> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Falcons GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

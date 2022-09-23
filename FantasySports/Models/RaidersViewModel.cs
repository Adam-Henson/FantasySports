using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class RaidersViewModel
    {
        private RaidersRepository _repo;
        public List<Raiders> TeamList { get; set; }
        public Raiders CurrentTeam { get; set; }
        public RaidersViewModel(FantasySportsContext context)
        {
            _repo = new RaidersRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public RaidersViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new RaidersRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Raiders();
            }
        }
        public List<Raiders> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Raiders GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

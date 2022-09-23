using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class LionsViewModel
    {
        private LionsRepository _repo;
        public List<Lions> TeamList { get; set; }
        public Lions CurrentTeam { get; set; }
        public LionsViewModel(FantasySportsContext context)
        {
            _repo = new LionsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public LionsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new LionsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Lions();
            }
        }
        public List<Lions> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Lions GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

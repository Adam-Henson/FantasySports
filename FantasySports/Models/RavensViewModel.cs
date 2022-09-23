using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class RavensViewModel
    {
        private RavensRepository _repo;
        public List<Ravens> TeamList { get; set; }
        public Ravens CurrentTeam { get; set; }
        public RavensViewModel(FantasySportsContext context)
        {
            _repo = new RavensRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public RavensViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new RavensRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Ravens();
            }
        }
        public List<Ravens> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Ravens GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

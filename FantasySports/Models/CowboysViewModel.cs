using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class CowboysViewModel
    {
        private CowboysRepository _repo;
        public List<Cowboys> TeamList { get; set; }
        public Cowboys CurrentTeam { get; set; }
        public CowboysViewModel(FantasySportsContext context)
        {
            _repo = new CowboysRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public CowboysViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new CowboysRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Cowboys();
            }
        }
        public List<Cowboys> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Cowboys GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

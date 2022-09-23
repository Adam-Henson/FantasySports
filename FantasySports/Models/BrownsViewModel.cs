using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class BrownsViewModel
    {
        private BrownsRepository _repo;
        public List<Browns> TeamList { get; set; }
        public Browns CurrentTeam { get; set; }
        public BrownsViewModel(FantasySportsContext context)
        {
            _repo = new BrownsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public BrownsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new BrownsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Browns();
            }
        }
        public List<Browns> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Browns GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class ChiefsViewModel
    {
        private ChiefsRepository _repo;
        public List<Chiefs> TeamList { get; set; }
        public Chiefs CurrentTeam { get; set; }
        public ChiefsViewModel(FantasySportsContext context)
        {
            _repo = new ChiefsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public ChiefsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new ChiefsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Chiefs();
            }
        }
        public List<Chiefs> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Chiefs GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class BillsViewModel
    {
        private BillsRepository _repo;
        public List<Bills> TeamList { get; set; }
        public Bills CurrentTeam { get; set; }
        public BillsViewModel(FantasySportsContext context)
        {
            _repo = new BillsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public BillsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new BillsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Bills();
            }
        }
        public List<Bills> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Bills GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

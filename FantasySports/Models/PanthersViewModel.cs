using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class PanthersViewModel
    {
        private PanthersRepository _repo;
        public List<Panthers> TeamList { get; set; }
        public Panthers CurrentTeam { get; set; }
        public PanthersViewModel(FantasySportsContext context)
        {
            _repo = new PanthersRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public PanthersViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new PanthersRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Panthers();
            }
        }
        public List<Panthers> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Panthers GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

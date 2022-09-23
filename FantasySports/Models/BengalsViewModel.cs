using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class BengalsViewModel
    {
        private BengalsRepository _repo;
        public List<Bengals> TeamList { get; set; }
        public Bengals CurrentTeam { get; set; }
        public BengalsViewModel(FantasySportsContext context)
        {
            _repo = new BengalsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public BengalsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new BengalsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Bengals();
            }
        }
        public List<Bengals> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Bengals GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

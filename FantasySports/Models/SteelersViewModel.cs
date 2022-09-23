using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class SteelersViewModel
    {
        private SteelersRepository _repo;
        public List<Steelers> TeamList { get; set; }
        public Steelers CurrentTeam { get; set; }
        public SteelersViewModel(FantasySportsContext context)
        {
            _repo = new SteelersRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public SteelersViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new SteelersRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Steelers();
            }
        }
        public List<Steelers> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Steelers GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class DolphinsViewModel
    {
        private DolphinsRepository _repo;
        public List<Dolphins> TeamList { get; set; }
        public Dolphins CurrentTeam { get; set; }
        public DolphinsViewModel(FantasySportsContext context)
        {
            _repo = new DolphinsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public DolphinsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new DolphinsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Dolphins();
            }
        }
        public List<Dolphins> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Dolphins GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

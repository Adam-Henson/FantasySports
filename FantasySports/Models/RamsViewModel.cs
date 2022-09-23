using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class RamsViewModel
    {
        private RamsRepository _repo;
        public List<Rams> TeamList { get; set; }
        public Rams CurrentTeam { get; set; }
        public RamsViewModel(FantasySportsContext context)
        {
            _repo = new RamsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public RamsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new RamsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Rams();
            }
        }
        public List<Rams> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Rams GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class EaglesViewModel
    {
        private EaglesRepository _repo;
        public List<Eagles> TeamList { get; set; }
        public Eagles CurrentTeam { get; set; }
        public EaglesViewModel(FantasySportsContext context)
        {
            _repo = new EaglesRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public EaglesViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new EaglesRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Eagles();
            }
        }
        public List<Eagles> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Eagles GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

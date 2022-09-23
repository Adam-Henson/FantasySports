using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class CardinalsViewModel
    {
        private CardinalsRepository _repo;
        public List<Cardinals> TeamList { get; set; }
        public Cardinals CurrentTeam { get; set; }
        public CardinalsViewModel(FantasySportsContext context)
        {
            _repo = new CardinalsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public CardinalsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new CardinalsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Cardinals();
            }
        }
        public List<Cardinals> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Cardinals GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

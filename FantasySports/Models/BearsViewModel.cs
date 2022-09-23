using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class BearsViewModel
    {
        private BearsRepository _repo;
        public List<Bears> TeamList { get; set; }
        public Bears CurrentTeam { get; set; }
        public BearsViewModel(FantasySportsContext context)
        {
            _repo = new BearsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public BearsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new BearsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Bears();
            }
        }
        public List<Bears> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Bears GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

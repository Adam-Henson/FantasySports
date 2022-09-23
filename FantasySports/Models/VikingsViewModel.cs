using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class VikingsViewModel
    {
        private VikingsRepository _repo;
        public List<Vikings> TeamList { get; set; }
        public Vikings CurrentTeam { get; set; }
        public VikingsViewModel(FantasySportsContext context)
        {
            _repo = new VikingsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public VikingsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new VikingsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Vikings();
            }
        }
        public List<Vikings> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Vikings GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

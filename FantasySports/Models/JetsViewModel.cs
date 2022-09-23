using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class JetsViewModel
    {
        private JetsRepository _repo;
        public List<Jets> TeamList { get; set; }
        public Jets CurrentTeam { get; set; }
        public JetsViewModel(FantasySportsContext context)
        {
            _repo = new JetsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public JetsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new JetsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Jets();
            }
        }
        public List<Jets> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Jets GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

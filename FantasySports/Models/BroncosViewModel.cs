using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class BroncosViewModel
    {
        private BroncosRepository _repo;
        public List<Broncos> TeamList { get; set; }
        public Broncos CurrentTeam { get; set; }
        public BroncosViewModel(FantasySportsContext context)
        {
            _repo = new BroncosRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public BroncosViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new BroncosRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Broncos();
            }
        }
        public List<Broncos> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Broncos GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

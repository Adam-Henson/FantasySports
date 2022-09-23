using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class ColtsViewModel
    {
        private ColtsRepository _repo;
        public List<Colts> TeamList { get; set; }
        public Colts CurrentTeam { get; set; }
        public ColtsViewModel(FantasySportsContext context)
        {
            _repo = new ColtsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public ColtsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new ColtsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Colts();
            }
        }
        public List<Colts> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Colts GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

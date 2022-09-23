using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class SeahawksViewModel
    {
        private SeahawksRepository _repo;
        public List<Seahawks> TeamList { get; set; }
        public Seahawks CurrentTeam { get; set; }
        public SeahawksViewModel(FantasySportsContext context)
        {
            _repo = new SeahawksRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public SeahawksViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new SeahawksRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Seahawks();
            }
        }
        public List<Seahawks> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Seahawks GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

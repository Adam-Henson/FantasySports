using CRUDApp.Context;
using CRUDApp.Models;
using CRUDApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace FantasySports.Models
{
    public class FootballViewModel
    {
        private FootballRepository _repo;
        public List<Football> TeamList { get; set; }
        public Football CurrentTeam { get; set; }
        public bool IsActionSuccess { get; set; }
        public string ActionMessage { get; set; }
        public FootballViewModel(FantasySportsContext context)
        {
            _repo = new FootballRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public FootballViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new FootballRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Football();
            }
        }
        public void SaveTeam(Football football)
        {
            if (football.TeamId > 0)
            {
                _repo.Update(football);
            }
            else
            {
                football.TeamId = _repo.Create(football);
            }
            TeamList = GetAllTeams();
            CurrentTeam = GetTeam(football.TeamId);
        }
        public void RemoveTeam(int teamID)
        {
            _repo.Delete(teamID);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public List<Football> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Football GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

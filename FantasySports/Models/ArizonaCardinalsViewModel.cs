using CRUDApp.Context;
using CRUDApp.Models;
using CRUDApp.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace FantasySports.Models
{
    public class ArizonaCardinalsViewModel
    {
        private ArizonaCardinalsRepository _repo;
        public List<ArizonaCardinals> TeamList { get; set; }
        public ArizonaCardinals CurrentTeam { get; set; }
        public bool IsActionSuccess { get; set; }
        public string ActionMessage { get; set; }
        public ArizonaCardinalsViewModel(FantasySportsContext context)
        {
            _repo = new ArizonaCardinalsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public ArizonaCardinalsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new ArizonaCardinalsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new ArizonaCardinals();
            }
        }
        public void SaveTeam(ArizonaCardinals football)
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
        public List<ArizonaCardinals> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public ArizonaCardinals GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

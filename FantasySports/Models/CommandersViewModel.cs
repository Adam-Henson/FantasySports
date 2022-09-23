using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class CommandersViewModel
    {
        private CommandersRepository _repo;
        public List<Commanders> TeamList { get; set; }
        public Commanders CurrentTeam { get; set; }
        public CommandersViewModel(FantasySportsContext context)
        {
            _repo = new CommandersRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public CommandersViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new CommandersRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Commanders();
            }
        }
        public List<Commanders> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Commanders GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

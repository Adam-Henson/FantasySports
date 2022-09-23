using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class ChargersViewModel
    {
        private ChargersRepository _repo;
        public List<Chargers> TeamList { get; set; }
        public Chargers CurrentTeam { get; set; }
        public ChargersViewModel(FantasySportsContext context)
        {
            _repo = new ChargersRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public ChargersViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new ChargersRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Chargers();
            }
        }
        public List<Chargers> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Chargers GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

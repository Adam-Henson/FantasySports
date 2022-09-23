using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class BuccaneersViewModel
    {
        private BuccaneersRepository _repo;
        public List<Buccaneers> TeamList { get; set; }
        public Buccaneers CurrentTeam { get; set; }
        public BuccaneersViewModel(FantasySportsContext context)
        {
            _repo = new BuccaneersRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public BuccaneersViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new BuccaneersRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Buccaneers();
            }
        }
        public List<Buccaneers> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Buccaneers GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

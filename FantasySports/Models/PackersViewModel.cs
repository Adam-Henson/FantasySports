using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class PackersViewModel
    {
        private PackersRepository _repo;
        public List<Packers> TeamList { get; set; }
        public Packers CurrentTeam { get; set; }
        public PackersViewModel(FantasySportsContext context)
        {
            _repo = new PackersRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public PackersViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new PackersRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Packers();
            }
        }
        public List<Packers> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Packers GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

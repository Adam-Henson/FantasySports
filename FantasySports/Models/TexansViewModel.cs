using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class TexansViewModel
    {
        private TexansRepository _repo;
        public List<Texans> TeamList { get; set; }
        public Texans CurrentTeam { get; set; }
        public TexansViewModel(FantasySportsContext context)
        {
            _repo = new TexansRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public TexansViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new TexansRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Texans();
            }
        }
        public List<Texans> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Texans GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasySports.Models
{
    public class JaguarsViewModel
    {
        private JaguarsRepository _repo;
        public List<Jaguars> TeamList { get; set; }
        public Jaguars CurrentTeam { get; set; }
        public JaguarsViewModel(FantasySportsContext context)
        {
            _repo = new JaguarsRepository(context);
            TeamList = GetAllTeams();
            CurrentTeam = TeamList.FirstOrDefault();
        }
        public JaguarsViewModel(FantasySportsContext context, int teamId)
        {
            _repo = new JaguarsRepository(context);
            TeamList = GetAllTeams();

            if (teamId > 0)
            {
                CurrentTeam = GetTeam(teamId);
            }
            else
            {
                CurrentTeam = new Jaguars();
            }
        }
        public List<Jaguars> GetAllTeams()
        {
            return _repo.GetAllTeams();
        }
        public Jaguars GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

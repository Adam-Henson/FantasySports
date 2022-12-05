using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FantasySports.Models
{
    public class FantasyFootballViewModel
    {
        private FantasyFootballRepository _repo;
        public List<FantasyFootball> TeamList { get; set; }
        public FantasyFootball CurrentPlayer { get; set; }

        public FantasyFootballViewModel(FantasySportsContext context)
        {
            _repo = new FantasyFootballRepository(context);
            TeamList = GetAllTeams();
            //CurrentTeam = TeamList.FirstOrDefault();
        }

        public int GetPoints(int playerGuess, int weeklyScore)
        {
            return _repo.Points(playerGuess, weeklyScore);
        }
        public List<FantasyFootball> GetAllTeams()
        {
            return TeamList;
            //return _repo.GetAllTeams();
        }
        public FantasyFootball GetTeam(int teamId)
        {
            return _repo.GetTeamByID(teamId);
        }
    }
}

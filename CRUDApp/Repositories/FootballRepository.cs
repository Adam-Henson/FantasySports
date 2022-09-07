using CRUDApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CRUDApp.Context;

namespace CRUDApp.Repositories
{
    public class FootballRepository
    {
        private FantasySportsContext _dbContext;
        public FootballRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(Football football)
        {
            _dbContext.Add(football);
            _dbContext.SaveChanges();

            return football.TeamId;
        }
        public int Update(Football football)
        {
            Football existingTeam = _dbContext.Football.Find(football.TeamId);

            existingTeam.Versus = football.Versus;
            existingTeam.TotalPoints = football.TotalPoints;
            existingTeam.SeasonRecord = football.SeasonRecord;

            _dbContext.SaveChanges();
            return football.TeamId;
        }
        public bool Delete(int teamID)
        {
            Football football = _dbContext.Football.Find(teamID);
            _dbContext.Remove(football);
            _dbContext.SaveChanges();

            return true;
        }
        public List<Football> GetAllTeams()
        {
            List<Football> teamList = _dbContext.Football.ToList();

            return teamList;
        }
        public Football GetTeamByID(int teamID)
        {
            Football football = _dbContext.Football.Find(teamID);

            return football;
        }
    }
}

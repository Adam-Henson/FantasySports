using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class PatriotsRepository
    {
        private FantasySportsContext _dbContext;

        public PatriotsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Patriots> GetAllTeams()
        {
            List<Patriots> teamList = _dbContext.Patriots.ToList();
            return teamList;
        }
        public Patriots GetTeamByID(int teamId)
        {
            Patriots football = _dbContext.Patriots.Find(teamId);
            return football;
        }
    }
}

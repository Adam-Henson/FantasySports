using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class LionsRepository
    {
        private FantasySportsContext _dbContext;

        public LionsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Lions> GetAllTeams()
        {
            List<Lions> teamList = _dbContext.Lions.ToList();
            return teamList;
        }
        public Lions GetTeamByID(int teamId)
        {
            Lions football = _dbContext.Lions.Find(teamId);
            return football;
        }
    }
}

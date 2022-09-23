using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class RavensRepository
    {
        private FantasySportsContext _dbContext;

        public RavensRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Ravens> GetAllTeams()
        {
            List<Ravens> teamList = _dbContext.Ravens.ToList();
            return teamList;
        }
        public Ravens GetTeamByID(int teamId)
        {
            Ravens football = _dbContext.Ravens.Find(teamId);
            return football;
        }
    }
}

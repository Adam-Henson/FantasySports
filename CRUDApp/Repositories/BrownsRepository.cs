using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class BrownsRepository
    {
        private FantasySportsContext _dbContext;

        public BrownsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Browns> GetAllTeams()
        {
            List<Browns> teamList = _dbContext.Browns.ToList();
            return teamList;
        }
        public Browns GetTeamByID(int teamId)
        {
            Browns football = _dbContext.Browns.Find(teamId);
            return football;
        }
    }
}

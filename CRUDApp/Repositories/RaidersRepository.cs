using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class RaidersRepository
    {
        private FantasySportsContext _dbContext;

        public RaidersRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Raiders> GetAllTeams()
        {
            List<Raiders> teamList = _dbContext.Raiders.ToList();
            return teamList;
        }
        public Raiders GetTeamByID(int teamId)
        {
            Raiders football = _dbContext.Raiders.Find(teamId);
            return football;
        }
    }
}

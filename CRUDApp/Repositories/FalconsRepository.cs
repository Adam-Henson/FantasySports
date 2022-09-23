using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class FalconsRepository
    {
        private FantasySportsContext _dbContext;

        public FalconsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Falcons> GetAllTeams()
        {
            List<Falcons> teamList = _dbContext.Falcons.ToList();
            return teamList;
        }
        public Falcons GetTeamByID(int teamId)
        {
            Falcons football = _dbContext.Falcons.Find(teamId);
            return football;
        }
    }
}

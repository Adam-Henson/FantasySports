using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class RamsRepository
    {
        private FantasySportsContext _dbContext;

        public RamsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Rams> GetAllTeams()
        {
            List<Rams> teamList = _dbContext.Rams.ToList();
            return teamList;
        }
        public Rams GetTeamByID(int teamId)
        {
            Rams football = _dbContext.Rams.Find(teamId);
            return football;
        }
    }
}

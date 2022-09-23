using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class BengalsRepository
    {
        private FantasySportsContext _dbContext;

        public BengalsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Bengals> GetAllTeams()
        {
            List<Bengals> teamList = _dbContext.Bengals.ToList();
            return teamList;
        }
        public Bengals GetTeamByID(int teamId)
        {
            Bengals football = _dbContext.Bengals.Find(teamId);
            return football;
        }
    }
}

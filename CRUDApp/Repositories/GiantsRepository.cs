using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class GiantsRepository
    {
        private FantasySportsContext _dbContext;

        public GiantsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Giants> GetAllTeams()
        {
            List<Giants> teamList = _dbContext.Giants.ToList();
            return teamList;
        }
        public Giants GetTeamByID(int teamId)
        {
            Giants football = _dbContext.Giants.Find(teamId);
            return football;
        }
    }
}

using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class ChiefsRepository
    {
        private FantasySportsContext _dbContext;

        public ChiefsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Chiefs> GetAllTeams()
        {
            List<Chiefs> teamList = _dbContext.Chiefs.ToList();
            return teamList;
        }
        public Chiefs GetTeamByID(int teamId)
        {
            Chiefs football = _dbContext.Chiefs.Find(teamId);
            return football;
        }
    }
}

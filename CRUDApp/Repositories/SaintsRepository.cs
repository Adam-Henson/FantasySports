using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class SaintsRepository
    {
        private FantasySportsContext _dbContext;

        public SaintsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Saints> GetAllTeams()
        {
            List<Saints> teamList = _dbContext.Saints.ToList();
            return teamList;
        }
        public Saints GetTeamByID(int teamId)
        {
            Saints football = _dbContext.Saints.Find(teamId);
            return football;
        }
    }
}

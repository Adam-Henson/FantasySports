using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class VikingsRepository
    {
        private FantasySportsContext _dbContext;

        public VikingsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Vikings> GetAllTeams()
        {
            List<Vikings> teamList = _dbContext.Vikings.ToList();
            return teamList;
        }
        public Vikings GetTeamByID(int teamId)
        {
            Vikings football = _dbContext.Vikings.Find(teamId);
            return football;
        }
    }
}

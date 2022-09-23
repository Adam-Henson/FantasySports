using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class JetsRepository
    {
        private FantasySportsContext _dbContext;

        public JetsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Jets> GetAllTeams()
        {
            List<Jets> teamList = _dbContext.Jets.ToList();
            return teamList;
        }
        public Jets GetTeamByID(int teamId)
        {
            Jets football = _dbContext.Jets.Find(teamId);
            return football;
        }
    }
}

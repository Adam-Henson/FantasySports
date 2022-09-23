using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class EaglesRepository
    {
        private FantasySportsContext _dbContext;

        public EaglesRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Eagles> GetAllTeams()
        {
            List<Eagles> teamList = _dbContext.Eagles.ToList();
            return teamList;
        }
        public Eagles GetTeamByID(int teamId)
        {
            Eagles football = _dbContext.Eagles.Find(teamId);
            return football;
        }
    }
}

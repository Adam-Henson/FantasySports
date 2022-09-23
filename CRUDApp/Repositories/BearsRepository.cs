using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class BearsRepository
    {
        private FantasySportsContext _dbContext;

        public BearsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Bears> GetAllTeams()
        {
            List<Bears> teamList = _dbContext.Bears.ToList();
            return teamList;
        }
        public Bears GetTeamByID(int teamId)
        {
            Bears football = _dbContext.Bears.Find(teamId);
            return football;
        }
    }
}

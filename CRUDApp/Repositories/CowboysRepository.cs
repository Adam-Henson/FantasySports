using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class CowboysRepository
    {
        private FantasySportsContext _dbContext;

        public CowboysRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cowboys> GetAllTeams()
        {
            List<Cowboys> teamList = _dbContext.Cowboys.ToList();
            return teamList;
        }
        public Cowboys GetTeamByID(int teamId)
        {
            Cowboys football = _dbContext.Cowboys.Find(teamId);
            return football;
        }
    }
}

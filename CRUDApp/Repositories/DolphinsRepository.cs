using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class DolphinsRepository
    {
        private FantasySportsContext _dbContext;

        public DolphinsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Dolphins> GetAllTeams()
        {
            List<Dolphins> teamList = _dbContext.Dolphins.ToList();
            return teamList;
        }
        public Dolphins GetTeamByID(int teamId)
        {
            Dolphins football = _dbContext.Dolphins.Find(teamId);
            return football;
        }
    }
}

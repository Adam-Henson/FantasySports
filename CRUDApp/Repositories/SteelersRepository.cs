using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class SteelersRepository
    {
        private FantasySportsContext _dbContext;

        public SteelersRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Steelers> GetAllTeams()
        {
            List<Steelers> teamList = _dbContext.Steelers.ToList();
            return teamList;
        }
        public Steelers GetTeamByID(int teamId)
        {
            Steelers football = _dbContext.Steelers.Find(teamId);
            return football;
        }
    }
}

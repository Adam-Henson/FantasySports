using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class ChargersRepository
    {
        private FantasySportsContext _dbContext;

        public ChargersRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Chargers> GetAllTeams()
        {
            List<Chargers> teamList = _dbContext.Chargers.ToList();
            return teamList;
        }
        public Chargers GetTeamByID(int teamId)
        {
            Chargers football = _dbContext.Chargers.Find(teamId);
            return football;
        }
    }
}

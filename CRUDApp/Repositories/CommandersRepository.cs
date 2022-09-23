using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class CommandersRepository
    {
        private FantasySportsContext _dbContext;

        public CommandersRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Commanders> GetAllTeams()
        {
            List<Commanders> teamList = _dbContext.Commanders.ToList();
            return teamList;
        }
        public Commanders GetTeamByID(int teamId)
        {
            Commanders football = _dbContext.Commanders.Find(teamId);
            return football;
        }
    }
}

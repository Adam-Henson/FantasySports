using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class BroncosRepository
    {
        private FantasySportsContext _dbContext;

        public BroncosRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Broncos> GetAllTeams()
        {
            List<Broncos> teamList = _dbContext.Broncos.ToList();
            return teamList;
        }
        public Broncos GetTeamByID(int teamId)
        {
            Broncos football = _dbContext.Broncos.Find(teamId);
            return football;
        }
    }
}

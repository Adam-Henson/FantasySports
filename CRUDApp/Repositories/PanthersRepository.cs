using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class PanthersRepository
    {
        private FantasySportsContext _dbContext;

        public PanthersRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Panthers> GetAllTeams()
        {
            List<Panthers> teamList = _dbContext.Panthers.ToList();
            return teamList;
        }
        public Panthers GetTeamByID(int teamId)
        {
            Panthers football = _dbContext.Panthers.Find(teamId);
            return football;
        }
    }
}

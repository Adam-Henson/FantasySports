using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class ColtsRepository
    {
        private FantasySportsContext _dbContext;

        public ColtsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Colts> GetAllTeams()
        {
            List<Colts> teamList = _dbContext.Colts.ToList();
            return teamList;
        }
        public Colts GetTeamByID(int teamId)
        {
            Colts football = _dbContext.Colts.Find(teamId);
            return football;
        }
    }
}

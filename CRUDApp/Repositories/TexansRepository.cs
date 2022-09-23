using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class TexansRepository
    {
        private FantasySportsContext _dbContext;

        public TexansRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Texans> GetAllTeams()
        {
            List<Texans> teamList = _dbContext.Texans.ToList();
            return teamList;
        }
        public Texans GetTeamByID(int teamId)
        {
            Texans football = _dbContext.Texans.Find(teamId);
            return football;
        }
    }
}

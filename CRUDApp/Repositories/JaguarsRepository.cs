using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class JaguarsRepository
    {
        private FantasySportsContext _dbContext;

        public JaguarsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Jaguars> GetAllTeams()
        {
            List<Jaguars> teamList = _dbContext.Jaguars.ToList();
            return teamList;
        }
        public Jaguars GetTeamByID(int teamId)
        {
            Jaguars football = _dbContext.Jaguars.Find(teamId);
            return football;
        }
    }
}

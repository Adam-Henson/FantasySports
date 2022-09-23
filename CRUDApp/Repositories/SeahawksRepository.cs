using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class SeahawksRepository
    {
        private FantasySportsContext _dbContext;

        public SeahawksRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Seahawks> GetAllTeams()
        {
            List<Seahawks> teamList = _dbContext.Seahawks.ToList();
            return teamList;
        }
        public Seahawks GetTeamByID(int teamId)
        {
            Seahawks football = _dbContext.Seahawks.Find(teamId);
            return football;
        }
    }
}

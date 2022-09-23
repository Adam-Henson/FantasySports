using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class _49ErsRepository
    {
        private FantasySportsContext _dbContext;

        public _49ErsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<_49Ers> GetAllTeams()
        {
            List<_49Ers> teamList = _dbContext._49Ers.ToList();
            return teamList;
        }
        public _49Ers GetTeamByID(int teamId)
        {
            _49Ers football = _dbContext._49Ers.Find(teamId);
            return football;
        }
    }
}

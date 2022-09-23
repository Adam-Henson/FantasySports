using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class BillsRepository
    {
        private FantasySportsContext _dbContext;

        public BillsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Bills> GetAllTeams()
        {
            List<Bills> teamList = _dbContext.Bills.ToList();
            return teamList;
        }
        public Bills GetTeamByID(int teamId)
        {
            Bills football = _dbContext.Bills.Find(teamId);
            return football;
        }
    }
}

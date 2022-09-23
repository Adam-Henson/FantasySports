using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class CardinalsRepository
    {
        private FantasySportsContext _dbContext;

        public CardinalsRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cardinals> GetAllTeams()
        {
            List<Cardinals> teamList = _dbContext.Cardinals.ToList();
            return teamList;
        }
        public Cardinals GetTeamByID(int teamId)
        {
            Cardinals cardinals = _dbContext.Cardinals.Find(teamId);
            return cardinals;
        }
    }
}

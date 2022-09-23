using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class BuccaneersRepository
    {
        private FantasySportsContext _dbContext;

        public BuccaneersRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Buccaneers> GetAllTeams()
        {
            List<Buccaneers> teamList = _dbContext.Buccaneers.ToList();
            return teamList;
        }
        public Buccaneers GetTeamByID(int teamId)
        {
            Buccaneers football = _dbContext.Buccaneers.Find(teamId);
            return football;
        }
    }
}

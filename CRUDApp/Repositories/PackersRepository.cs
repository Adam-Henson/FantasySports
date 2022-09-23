using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class PackersRepository
    {
        private FantasySportsContext _dbContext;

        public PackersRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Packers> GetAllTeams()
        {
            List<Packers> teamList = _dbContext.Packers.ToList();
            return teamList;
        }
        public Packers GetTeamByID(int teamId)
        {
            Packers football = _dbContext.Packers.Find(teamId);
            return football;
        }
    }
}

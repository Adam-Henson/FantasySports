using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CRUDApp.Models;
using CRUDApp.Context;

namespace CRUDApp.Repositories
{
    public class ArizonaCardinalsRepository
    {
        private FantasySportsContext _dbcontext;
        public ArizonaCardinalsRepository(FantasySportsContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public int Create(ArizonaCardinals football)
        {
            _dbcontext.Add(football);
            _dbcontext.SaveChanges();

            return football.TeamId;
        }
        public int Update(ArizonaCardinals football)
        {
            ArizonaCardinals existingteam = _dbcontext.ArizonaCardinals.Find(football.TeamId);

            existingteam.MyTeam = football.MyTeam;
            existingteam.Versus = football.Versus;
            existingteam.Score = football.Score;
            existingteam.SeasonRecord = football.SeasonRecord;

            _dbcontext.SaveChanges();
            return football.TeamId;
        }
        public bool Delete(int teamid)
        {
            ArizonaCardinals football = _dbcontext.ArizonaCardinals.Find(teamid);
            _dbcontext.Remove(football);
            _dbcontext.SaveChanges();

            return true;
        }
        public List<ArizonaCardinals> GetAllTeams()
        {
            List<ArizonaCardinals> teamlist = _dbcontext.ArizonaCardinals.ToList();

            return teamlist;
        }
        public ArizonaCardinals GetTeamByID(int teamid)
        {
            ArizonaCardinals football = _dbcontext.ArizonaCardinals.Find(teamid);

            return football;
        }
    }
}

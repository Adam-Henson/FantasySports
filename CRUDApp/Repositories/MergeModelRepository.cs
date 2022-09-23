using CRUDApp.Context;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUDApp.Repositories
{
    public class MergeModelRepository
    {
        private FantasySportsContext _dbContext;

        public MergeModelRepository(FantasySportsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<_49Ers> Get_49Ers()
        {
            List<_49Ers> teamList = _dbContext._49Ers.ToList();
            return teamList;
        }
        public _49Ers Get_49ErsID(int teamId)
        {
            _49Ers football = _dbContext._49Ers.Find(teamId);
            return football;
        }
        public List<Bears> GetBears()
        {
            List<Bears> teamList = _dbContext.Bears.ToList();
            return teamList;
        }
        public Bears GetBearsID(int teamId)
        {
            Bears football = _dbContext.Bears.Find(teamId);
            return football;
        }
        public List<Bengals> GetBengals()
        {
            List<Bengals> teamList = _dbContext.Bengals.ToList();
            return teamList;
        }
        public Bengals GetBengalsID(int teamId)
        {
            Bengals football = _dbContext.Bengals.Find(teamId);
            return football;
        }
        public List<Bills> GetBills()
        {
            List<Bills> teamList = _dbContext.Bills.ToList();
            return teamList;
        }
        public Bills GetBillsID(int teamId)
        {
            Bills football = _dbContext.Bills.Find(teamId);
            return football;
        }
        public List<Broncos> GetBroncos()
        {
            List<Broncos> teamList = _dbContext.Broncos.ToList();
            return teamList;
        }
        public Broncos GetBroncosID(int teamId)
        {
            Broncos football = _dbContext.Broncos.Find(teamId);
            return football;
        }
        public List<Browns> GetBrowns()
        {
            List<Browns> teamList = _dbContext.Browns.ToList();
            return teamList;
        }
        public Browns GetBrownsID(int teamId)
        {
            Browns football = _dbContext.Browns.Find(teamId);
            return football;
        }
        public List<Buccaneers> GetBuccaneers()
        {
            List<Buccaneers> teamList = _dbContext.Buccaneers.ToList();
            return teamList;
        }
        public Buccaneers GetBuccaneersID(int teamId)
        {
            Buccaneers football = _dbContext.Buccaneers.Find(teamId);
            return football;
        }
        public List<Cardinals> GetCardinals()
        {
            List<Cardinals> teamList = _dbContext.Cardinals.ToList();
            return teamList;
        }
        public Cardinals GetCardinalsID(int teamId)
        {
            Cardinals football = _dbContext.Cardinals.Find(teamId);
            return football;
        }
        public List<Chargers> GetChargers()
        {
            List<Chargers> teamList = _dbContext.Chargers.ToList();
            return teamList;
        }
        public Chargers GetChargersID(int teamId)
        {
            Chargers football = _dbContext.Chargers.Find(teamId);
            return football;
        }
        public List<Chiefs> GetChiefs()
        {
            List<Chiefs> teamList = _dbContext.Chiefs.ToList();
            return teamList;
        }
        public Chiefs GetChiefsID(int teamId)
        {
            Chiefs football = _dbContext.Chiefs.Find(teamId);
            return football;
        }
        public List<Colts> GetColts()
        {
            List<Colts> teamList = _dbContext.Colts.ToList();
            return teamList;
        }
        public Colts GetColtsID(int teamId)
        {
            Colts football = _dbContext.Colts.Find(teamId);
            return football;
        }
        public List<Commanders> GetCommanders()
        {
            List<Commanders> teamList = _dbContext.Commanders.ToList();
            return teamList;
        }
        public Commanders GetCommandersID(int teamId)
        {
            Commanders football = _dbContext.Commanders.Find(teamId);
            return football;
        }
        public List<Cowboys> GetCowboys()
        {
            List<Cowboys> teamList = _dbContext.Cowboys.ToList();
            return teamList;
        }
        public Cowboys GetCowboysID(int teamId)
        {
            Cowboys football = _dbContext.Cowboys.Find(teamId);
            return football;
        }
        public List<Dolphins> GetDolphins()
        {
            List<Dolphins> teamList = _dbContext.Dolphins.ToList();
            return teamList;
        }
        public Dolphins GetDolphinsID(int teamId)
        {
            Dolphins football = _dbContext.Dolphins.Find(teamId);
            return football;
        }
        public List<Eagles> GetEagles()
        {
            List<Eagles> teamList = _dbContext.Eagles.ToList();
            return teamList;
        }
        public Eagles GetEaglesID(int teamId)
        {
            Eagles football = _dbContext.Eagles.Find(teamId);
            return football;
        }
        public List<Falcons> GetFalcons()
        {
            List<Falcons> teamList = _dbContext.Falcons.ToList();
            return teamList;
        }
        public Falcons GetFalconsID(int teamId)
        {
            Falcons football = _dbContext.Falcons.Find(teamId);
            return football;
        }
        public List<Giants> GetGiants()
        {
            List<Giants> teamList = _dbContext.Giants.ToList();
            return teamList;
        }
        public Giants GetGiantsID(int teamId)
        {
            Giants football = _dbContext.Giants.Find(teamId);
            return football;
        }
        public List<Jaguars> GetJaguars()
        {
            List<Jaguars> teamList = _dbContext.Jaguars.ToList();
            return teamList;
        }
        public Jaguars GetJaguarsID(int teamId)
        {
            Jaguars football = _dbContext.Jaguars.Find(teamId);
            return football;
        }
        public List<Jets> GetJets()
        {
            List<Jets> teamList = _dbContext.Jets.ToList();
            return teamList;
        }
        public Jets GetJetsID(int teamId)
        {
            Jets football = _dbContext.Jets.Find(teamId);
            return football;
        }
        public List<Lions> GetLions()
        {
            List<Lions> teamList = _dbContext.Lions.ToList();
            return teamList;
        }
        public Lions GetLionsID(int teamId)
        {
            Lions football = _dbContext.Lions.Find(teamId);
            return football;
        }
        public List<Packers> GetPackers()
        {
            List<Packers> teamList = _dbContext.Packers.ToList();
            return teamList;
        }
        public Packers GetPackersID(int teamId)
        {
            Packers football = _dbContext.Packers.Find(teamId);
            return football;
        }
        public List<Panthers> GetPanthers()
        {
            List<Panthers> teamList = _dbContext.Panthers.ToList();
            return teamList;
        }
        public Panthers GetPanthersID(int teamId)
        {
            Panthers football = _dbContext.Panthers.Find(teamId);
            return football;
        }
        public List<Patriots> GetPatriots()
        {
            List<Patriots> teamList = _dbContext.Patriots.ToList();
            return teamList;
        }
        public Patriots GetPatriotsID(int teamId)
        {
            Patriots football = _dbContext.Patriots.Find(teamId);
            return football;
        }
        public List<Raiders> GetRaiders()
        {
            List<Raiders> teamList = _dbContext.Raiders.ToList();
            return teamList;
        }
        public Raiders GetRaidersID(int teamId)
        {
            Raiders football = _dbContext.Raiders.Find(teamId);
            return football;
        }
        public List<Rams> GetRams()
        {
            List<Rams> teamList = _dbContext.Rams.ToList();
            return teamList;
        }
        public Rams GetRamsID(int teamId)
        {
            Rams football = _dbContext.Rams.Find(teamId);
            return football;
        }
        public List<Ravens> GetRavens()
        {
            List<Ravens> teamList = _dbContext.Ravens.ToList();
            return teamList;
        }
        public Ravens GetRavensID(int teamId)
        {
            Ravens football = _dbContext.Ravens.Find(teamId);
            return football;
        }
        public List<Saints> GetSaints()
        {
            List<Saints> teamList = _dbContext.Saints.ToList();
            return teamList;
        }
        public Saints GetSaintsID(int teamId)
        {
            Saints football = _dbContext.Saints.Find(teamId);
            return football;
        }
        public List<Seahawks> GetSeahawks()
        {
            List<Seahawks> teamList = _dbContext.Seahawks.ToList();
            return teamList;
        }
        public Seahawks GetSeahawksID(int teamId)
        {
            Seahawks football = _dbContext.Seahawks.Find(teamId);
            return football;
        }
        public List<Steelers> GetSteelers()
        {
            List<Steelers> teamList = _dbContext.Steelers.ToList();
            return teamList;
        }
        public Steelers GetSteelersID(int teamId)
        {
            Steelers football = _dbContext.Steelers.Find(teamId);
            return football;
        }
        public List<Texans> GetTexans()
        {
            List<Texans> teamList = _dbContext.Texans.ToList();
            return teamList;
        }
        public Texans GetTexansID(int teamId)
        {
            Texans football = _dbContext.Texans.Find(teamId);
            return football;
        }
        public List<Titans> GetTitans()
        {
            List<Titans> teamList = _dbContext.Titans.ToList();
            return teamList;
        }
        public Titans GetTitansID(int teamId)
        {
            Titans football = _dbContext.Titans.Find(teamId);
            return football;
        }
        public List<Vikings> GetVikings()
        {
            List<Vikings> teamList = _dbContext.Vikings.ToList();
            return teamList;
        }
        public Vikings GetVikingsID(int teamId)
        {
            Vikings football = _dbContext.Vikings.Find(teamId);
            return football;
        }


        public int Points()
        {
            int points = 0;
            int playerGuess = 0;
            int weeklyScore = 0;

            if (playerGuess == weeklyScore + 14)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore + 13)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore + 12)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore + 11)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore + 10)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 9)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 8)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 7)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 6)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 5)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 4)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore + 3)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore + 2)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore + 1)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore - 1)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore - 2)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore - 3)
            {
                points += 5;
            }
            if (playerGuess == weeklyScore - 4)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 5)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 6)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 7)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 8)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 9)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 10)
            {
                points += 3;
            }
            if (playerGuess == weeklyScore - 11)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore - 12)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore - 13)
            {
                points += 1;
            }
            if (playerGuess == weeklyScore - 14)
            {
                points += 1;
            }
            return points;
        }
    }
}

using CRUDApp.Repositories;
using CRUDApp.Context;
using CRUDApp.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FantasySports.Models
{
    public class MergeModelViewModel
    {
        private FantasyFootballRepository _repo;
        public List<_49Ers> _49Ers { get; set; }
        public List<Bears> Bears { get; set; }
        public List<Bengals> Bengals { get; set; }
        public List<Bills> Bills { get; set; }
        public List<Broncos> Broncos { get; set; }
        public List<Browns> Browns { get; set; }
        public List<Buccaneers> Buccaneers { get; set; }
        public List<Cardinals> Cardinals { get; set; }
        public List<Chargers> Chargers { get; set; }
        public List<Chiefs> Chiefs { get; set; }
        public List<Colts> Colts { get; set; }
        public List<Commanders> Commanders { get; set; }
        public List<Cowboys> Cowboys { get; set; }
        public List<Dolphins> Dolphins { get; set; }
        public List<Eagles> Eagles { get; set; }
        public List<Falcons> Falcons { get; set; }
        public List<Giants> Giants { get; set; }
        public List<Jaguars> Jaguars { get; set; }
        public List<Jets> Jets { get; set; }
        public List<Lions> Lions { get; set; }
        public List<Packers> Packers { get; set; }
        public List<Panthers> Panthers { get; set; }
        public List<Patriots> Patriots { get; set; }
        public List<Raiders> Raiders { get; set; }
        public List<Rams> Rams { get; set; }
        public List<Ravens> Ravens { get; set; }
        public List<Saints> Saints { get; set; }
        public List<Seahawks> Seahawks { get; set; }
        public List<Steelers> Steelers { get; set; }
        public List<Texans> Texans { get; set; }
        public List<Titans> Titans { get; set; }
        public List<Vikings> Vikings { get; set; }
        public _49Ers Current_49Ers { get; set; }
        public Bears CurrentBears { get; set; }
        public Bengals CurrentBengals { get; set; }
        public Bills CurrentBills { get; set; }
        public Broncos CurrentBroncos { get; set; }
        public Browns CurrentBrowns { get; set; }
        public Buccaneers CurrentBuccaneers { get; set; }
        public Cardinals CurrentCardinals { get; set; }
        public Chargers CurrentChargers { get; set; }
        public Chiefs CurrentChiefs { get; set; }
        public Colts CurrentColts { get; set; }
        public Commanders CurrentCommanders { get; set; }
        public Cowboys CurrentCowboys { get; set; }
        public Dolphins CurrentDolphins { get; set; }
        public Eagles CurrentEagles { get; set; }
        public Falcons CurrentFalcons { get; set; }
        public Giants CurrentGiants { get; set; }
        public Jaguars CurrentJaguars { get; set; }
        public Jets CurrentJets { get; set; }
        public Lions CurrentLions { get; set; }
        public Packers CurrentPackers { get; set; }
        public Panthers CurrentPanthers { get; set; }
        public Patriots CurrentPatriots { get; set; }
        public Raiders CurrentRaiders { get; set; }
        public Rams CurrentRams { get; set; }
        public Ravens CurrentRavens { get; set; }
        public Saints CurrentSaints { get; set; }
        public Seahawks CurrentSeahawks { get; set; }
        public Steelers CurrentSteelers { get; set; }
        public Texans CurrentTexans { get; set; }
        public Titans CurrentTitans { get; set; }
        public Vikings CurrentVikings { get; set; }

        public MergeModelViewModel(FantasySportsContext context)
        {
            _repo = new FantasyFootballRepository(context);
            _49Ers = Get_49Ers();
            Current_49Ers = _49Ers.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Bears = GetBears();
            CurrentBears = Bears.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Bengals = GetBengals();
            CurrentBengals = Bengals.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Bills = GetBills();
            CurrentBills = Bills.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Broncos = GetBroncos();
            CurrentBroncos = Broncos.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Browns = GetBrowns();
            CurrentBrowns = Browns.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Buccaneers = GetBuccaneers();
            CurrentBuccaneers = Buccaneers.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Cardinals = GetCardinals();
            CurrentCardinals = Cardinals.FirstOrDefault();
            
            _repo = new FantasyFootballRepository(context);
            Chargers = GetChargers();
            CurrentChargers = Chargers.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Chiefs = GetChiefs();
            CurrentChiefs = Chiefs.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Colts = GetColts();
            CurrentColts = Colts.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Commanders = GetCommanders();
            CurrentCommanders = Commanders.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Cowboys = GetCowboys();
            CurrentCowboys = Cowboys.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Dolphins = GetDolphins();
            CurrentDolphins = Dolphins.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Eagles = GetEagles();
            CurrentEagles = Eagles.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Falcons = GetFalcons();
            CurrentFalcons = Falcons.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Giants = GetGiants();
            CurrentGiants = Giants.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Jaguars = GetJaguars();
            CurrentJaguars = Jaguars.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Jets = GetJets();
            CurrentJets = Jets.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Lions = GetLions();
            CurrentLions = Lions.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Packers = GetPackers();
            CurrentPackers = Packers.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Panthers = GetPanthers();
            CurrentPanthers = Panthers.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Patriots = GetPatriots();
            CurrentPatriots = Patriots.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Raiders = GetRaiders();
            CurrentRaiders = Raiders.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Rams = GetRams();
            CurrentRams = Rams.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Ravens = GetRavens();
            CurrentRavens = Ravens.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Saints = GetSaints();
            CurrentSaints = Saints.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Seahawks = GetSeahawks();
            CurrentSeahawks = Seahawks.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Steelers = GetSteelers();
            CurrentSteelers = Steelers.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Texans = GetTexans();
            CurrentTexans = Texans.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Titans = GetTitans();
            CurrentTitans = Titans.FirstOrDefault();

            _repo = new FantasyFootballRepository(context);
            Vikings = GetVikings();
            CurrentVikings = Vikings.FirstOrDefault();

        }
      

        public List<_49Ers> Get_49Ers()
        {
            return _repo.Get_49Ers();
        }
        public _49Ers Get_49ErsID(int teamId)
        {
            return _repo.Get_49ErsID(teamId);
        }
        public List<Bears> GetBears()
        {
            return _repo.GetBears();
        }
        public Bears GetBearsID(int teamId)
        {
            return _repo.GetBearsID(teamId);
        }
        public List<Bengals> GetBengals()
        {
            return _repo.GetBengals();  
        }
        public Bengals GetBengalsID(int teamId)
        {
            return _repo.GetBengalsID(teamId);
        }
        public List<Bills> GetBills()
        {
            return _repo.GetBills();
        }
        public Bills GetBillsID(int teamId)
        {
            return _repo.GetBillsID(teamId);
        }
        public List<Broncos> GetBroncos()
        {
            return _repo.GetBroncos();
        }
        public Broncos GetBroncosID(int teamId)
        {
            return _repo.GetBroncosID(teamId);
        }
        public List<Browns> GetBrowns()
        {
            return _repo.GetBrowns();
        }
        public Browns GetBrownsID(int teamId)
        {
            return _repo.GetBrownsID(teamId);
        }
        public List<Buccaneers> GetBuccaneers()
        {
            return _repo.GetBuccaneers();
        }
        public Buccaneers GetBuccaneersID(int teamId)
        {
            return _repo.GetBuccaneersID(teamId);
        }
        public List<Cardinals> GetCardinals()
        {
            return _repo.GetCardinals();
        }
        public Cardinals GetCardinalsID(int teamId)
        {
         return _repo.GetCardinalsID(teamId);   
        }
        public List<Chargers> GetChargers()
        {
            return _repo.GetChargers();
        }
        public Chargers GetChargersID(int teamId)
        {
            return _repo.GetChargersID(teamId);
        }
        public List<Chiefs> GetChiefs()
        {
            return _repo.GetChiefs();
        }
        public Chiefs GetChiefsID(int teamId)
        {
            return _repo.GetChiefsID(teamId);
        }
        public List<Colts> GetColts()
        {
            return _repo.GetColts();
        }
        public Colts GetColtsID(int teamId)
        {
            return _repo.GetColtsID(teamId);
        }
        public List<Commanders> GetCommanders()
        {
            return _repo.GetCommanders();
        }
        public Commanders GetCommandersID(int teamId)
        {
            return _repo.GetCommandersID(teamId);
        }
        public List<Cowboys> GetCowboys()
        {
            return _repo.GetCowboys();
        }
        public Cowboys GetCowboysID(int teamId)
        {
            return _repo.GetCowboysID(teamId);
        }
        public List<Dolphins> GetDolphins()
        {
            return _repo.GetDolphins();
        }
        public Dolphins GetDolphinsID(int teamId)
        {
            return _repo.GetDolphinsID(teamId);
        }
        public List<Eagles> GetEagles()
        {
            return _repo.GetEagles();
        }
        public Eagles GetEaglesID(int teamId)
        {
            return _repo.GetEaglesID(teamId);
        }
        public List<Falcons> GetFalcons()
        {
            return _repo.GetFalcons();
        }
        public Falcons GetFalconsID(int teamId)
        {
            return _repo.GetFalconsID(teamId);
        }
        public List<Giants> GetGiants()
        {
            return _repo.GetGiants();
        }
        public Giants GetGiantsID(int teamId)
        {
            return _repo.GetGiantsID(teamId);
        }
        public List<Jaguars> GetJaguars()
        {
            return _repo.GetJaguars();
        }
        public Jaguars GetJaguarsID(int teamId)
        {
            return _repo.GetJaguarsID(teamId);
        }
        public List<Jets> GetJets()
        {
            return _repo.GetJets();
        }
        public Jets GetJetsID(int teamId)
        {
            return _repo.GetJetsID(teamId);
        }
        public List<Lions> GetLions()
        {
            return _repo.GetLions();
        }
        public Lions GetLionsID(int teamId)
        {
            return _repo.GetLionsID(teamId);
        }
        public List<Packers> GetPackers()
        {
            return _repo.GetPackers();
        }
        public Packers GetPackersID(int teamId)
        {
            return _repo.GetPackersID(teamId);
        }
        public List<Panthers> GetPanthers()
        {
            return _repo.GetPanthers();
        }
        public Panthers GetPanthersID(int teamId)
        {
            return _repo.GetPanthersID(teamId);
        }
        public List<Patriots> GetPatriots()
        {
            return _repo.GetPatriots();
        }
        public Patriots GetPatriotsID(int teamId)
        {
            return _repo.GetPatriotsID(teamId);
        }
        public List<Raiders> GetRaiders()
        {
            return _repo.GetRaiders();
        }
        public Raiders GetRaidersID(int teamId)
        {
            return _repo.GetRaidersID(teamId);
        }
        public List<Rams> GetRams()
        {
            return _repo.GetRams();
        }
        public Rams GetRamsID(int teamId)
        {
            return _repo.GetRamsID(teamId);
        }
        public List<Ravens> GetRavens()
        {
            return _repo.GetRavens();
        }
        public Ravens GetRavensID(int teamId)
        {
            return _repo.GetRavensID(teamId);
        }
        public List<Saints> GetSaints()
        {
            return _repo.GetSaints();
        }
        public Saints GetSaintsID(int teamId)
        {
            return _repo.GetSaintsID(teamId);
        }
        public List<Seahawks> GetSeahawks()
        {
            return _repo.GetSeahawks();
        }
        public Seahawks GetSeahawksID(int teamId)
        {
            return _repo.GetSeahawksID(teamId);
        }
        public List<Steelers> GetSteelers()
        {
            return _repo.GetSteelers();
        }
        public Steelers GetSteelersID(int teamId)
        {
            return _repo.GetSteelersID(teamId);
        }
        public List<Texans> GetTexans()
        {
            return _repo.GetTexans();
        }
        public Texans GetTexansID(int teamId)
        {
            return _repo.GetTexansID(teamId);
        }
        public List<Titans> GetTitans()
        {
            return _repo.GetTitans();
        }
        public Titans GetTitansID(int teamId)
        {
            return _repo.GetTitansID(teamId);
        }
        public List<Vikings> GetVikings()
        {
            return _repo.GetVikings();
        }
        public Vikings GetVikingsID(int teamId)
        {
            return _repo.GetVikingsID(teamId);
        }


        public int GetPoints()
        {
            return _repo.Points();
        }
    }
}

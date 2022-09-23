using CRUDApp.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace FantasySports.Models
{
    public enum Team
    {
        SanFrancisco = 1,

    }
    public class MergeModel
    {
        public int playerGuess { get; set; }
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
    }
}

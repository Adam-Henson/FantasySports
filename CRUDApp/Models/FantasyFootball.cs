using CRUDApp.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace FantasySports.Models
{
    public enum Team
    {
        _49Ers = 1,
        Bears = 2,
        Bengals = 3,
        Bills = 4,
        Broncos = 5,
        Browns = 6,
        Buccaneers = 7,
        Cardinals = 8,
        Chargers = 9,
        Chiefs = 10,
        Colts = 11,
        Commanders = 12,
        Cowboys = 13,
        Dolphins = 14,
        Eagles = 15,
        Falcons = 16,
        Giants = 17,
        Jaguars = 18,
        Jets = 19,
        Lions = 20,
        Packers = 21,
        Panthers = 22,
        Patriots = 23,
        Raiders = 24,
        Rams = 25,
        Ravens = 26,
        Saints = 27,
        Seahawks = 28,
        Steelers = 29,
        Texans = 30,
        Titans = 31,
        Vikings = 32
    }
    public class FantasyFootball
    {
        public int playerGuess { get; set; }
        public int TeamId { get; set; }
        public int? Week1Score { get; set; }
        public int? Week2Score { get; set; }
        public int? Week3Score { get; set; }
        public int? Week4Score { get; set; }
        public int? Week5Score { get; set; }
        public int? Week6Score { get; set; }
        public int? Week7Score { get; set; }
        public int? Week8Score { get; set; }
        public int? Week9Score { get; set; }
        public int? Week10Score { get; set; }
        public int? Week11Score { get; set; }
        public int? Week12Score { get; set; }
        public int? Week13Score { get; set; }
        public int? Week14Score { get; set; }
        public int? Week15Score { get; set; }
        public int? Week16Score { get; set; }
        public int? Week17Score { get; set; }
        public int? Week18Score { get; set; }
    }
}

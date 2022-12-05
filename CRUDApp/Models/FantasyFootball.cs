using CRUDApp.Models;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace FantasySports.Models
{
    public enum PlayerID
    {
        player1 = 1,
        player2 = 2,
        player3 = 3,
        player4 = 4,
        player5 = 5
    }
    public enum TeamID
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
        public int TeamId { get; set; }
        public int? Week1Points { get; set; }
        public int? Week2Points { get; set; }
        public int? Week3Points { get; set; }
        public int? Week4Points { get; set; }
        public int? Week5Points { get; set; }
        public int? Week6Points { get; set; }
        public int? Week7Points { get; set; }
        public int? Week8Points { get; set; }
        public int? Week9Points { get; set; }
        public int? Week10Points { get; set; }
        public int? Week11Points { get; set; }
        public int? Week12Points { get; set; }
        public int? Week13Points { get; set; }
        public int? Week14Points { get; set; }
        public int? Week15Points { get; set; }
        public int? Week16Points { get; set; }
        public int? Week17Points { get; set; }
        public int? Week18Points { get; set; }
        public int? PlayerPoints { get; set; }
        public int? PlayerGuess { get; set; }
    }
}

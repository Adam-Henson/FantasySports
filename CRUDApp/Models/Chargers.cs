using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CRUDApp.Models
{
    public partial class Chargers
    {
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
        public Chargers(int teamId, int? week1Score, int? week2Score, int? week3Score, int? week4Score, int? week5Score, int? week6Score, int? week7Score, int? week8Score, int? week9Score, int? week10Score, int? week11Score, int? week12Score, int? week13Score, int? week14Score, int? week15Score, int? week16Score, int? week17Score, int? week18Score)
        {
            TeamId = teamId;
            Week1Score = week1Score;
            Week2Score = week2Score;
            Week3Score = week3Score;
            Week4Score = week4Score;
            Week5Score = week5Score;
            Week6Score = week6Score;
            Week7Score = week7Score;
            Week8Score = week8Score;
            Week9Score = week9Score;
            Week10Score = week10Score;
            Week11Score = week11Score;
            Week12Score = week12Score;
            Week13Score = week13Score;
            Week14Score = week14Score;
            Week15Score = week15Score;
            Week16Score = week16Score;
            Week17Score = week17Score;
            Week18Score = week18Score;
        }
        public Chargers()
        {

        }
    }
}

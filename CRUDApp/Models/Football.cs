using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CRUDApp.Models
{
    public partial class Football
    {
        public int TeamId { get; set; }
        public string Versus { get; set; }
        public int TotalPoints { get; set; }
        public string SeasonRecord { get; set; }
        public Football(int teamId, string versus, int totalPoints, string seasonRecord)
        {
            TeamId = teamId;
            Versus = versus;
            TotalPoints = totalPoints;
            SeasonRecord = seasonRecord;
        }
        public Football()
        {

        }
    }
}

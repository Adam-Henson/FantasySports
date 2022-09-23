using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CRUDApp.Models
{
    public partial class ArizonaCardinals
    {
        public int TeamId { get; set; }
        public string MyTeam { get; set; }
        public string Versus { get; set; }
        public string Score { get; set; }
        public string SeasonRecord { get; set; }
        public ArizonaCardinals(int teamId, string myTeam, string versus, string score, string seasonRecord)
        {
            TeamId = teamId;
            MyTeam = myTeam;
            Versus = versus;
            Score = score;
            SeasonRecord = seasonRecord;
        }
        public ArizonaCardinals()
        {

        }
    }
}

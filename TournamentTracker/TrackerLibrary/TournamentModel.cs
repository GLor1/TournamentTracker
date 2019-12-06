using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModels> EnteredTeams { get; set; } = new List<TeamModels>();
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchUpModel>> Rounds { get; set; } new List<List<MatchupModel>>();
    }
}

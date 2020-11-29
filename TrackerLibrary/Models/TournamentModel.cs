using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// un id unic pentru turneu
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// reprezinta numele turneului
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// reprezinta plata de intrare
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// reprezinta echipele intrate
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// reprezinta o lista cu premiile
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// reprezinta o lista cu rundele turneului
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}

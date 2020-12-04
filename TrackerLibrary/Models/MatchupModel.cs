using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// id unic pentru meci
        /// </summary>
        public int Id { get; set; }
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// id-ul din baza de date folosit pentru identificarea castigatorului
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// reprezinta castigatorul meciului
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// reprezinta runda in care joaca 2 echipe
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                    if (output.Length == 0)
                    {
                        output = me.TeamCompeting.TeamName;
                    }
                    else
                    {
                        output += $" vs. { me.TeamCompeting.TeamName }";
                    }
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }
                return output;
            }
        }
    }
}


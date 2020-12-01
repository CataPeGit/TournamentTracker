using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// id unic pentru meci
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// reprezinta o echipa din meci
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// reprezinta scorul acestei echipe
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// reprezinta meciul castigat de echipa
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
        
        

    }
}

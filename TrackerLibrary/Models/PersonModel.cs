using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// id unic pentru PersonModel
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// reprezinta primul nume  
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// reprezinta al doilea nume
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// reprezinta adresa de email a jucatorului
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// reprezinta numarul de telefon in cazul in care exista
        /// </summary>
        public string CellPhoneNumber { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}

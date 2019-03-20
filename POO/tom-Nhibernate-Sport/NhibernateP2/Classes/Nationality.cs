/* Project : NhibernateP2
 * Description : C# application who usen Nhibernate to manipulate database
 * Author : Tom RYSER
 * Version : 1.0
 * Last update : 24.12.2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2
{
    public class Nationality
    {

        public virtual int Id_Athlete { get; set; }
        public virtual int Id_Country { get; set; }
        public Nationality()
        {

        }

        public Nationality(int idAthlete, int idCountry)
        {
            Id_Athlete = idAthlete;
            Id_Country = idCountry;
        }

        /// <summary>
        /// https://stackoverflow.com/a/7919012/10736081
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var other = obj as Nationality;

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return this.Id_Athlete == other.Id_Athlete &&
                this.Id_Country == other.Id_Country;
        }

        /// <summary>
        /// https://stackoverflow.com/a/7919012/10736081
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = GetType().GetHashCode();
                return hash;
            }
        }
    }
}

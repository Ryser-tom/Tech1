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
    public class Address
    {
        public virtual int Id { get; set; }
        public virtual DateTime Valid_from { get; set; }
        public virtual DateTime Valid_to { get; set; }
        public virtual string Street_nr { get; set; }
        public virtual string Street { get; set; }
        public virtual string Postal_code { get; set; }
        public virtual string Location { get; set; }
        public virtual Country Country { get; set; }
        public virtual Athlete Athlete { get; set; }
        public virtual int Id_Country { get; set; }
        public Address()
        {

        }
    }
}

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
    public class Country
    {
        public virtual int Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Athlete> Athletes { get; set; }
        public Country()
        {

        }
    }
}

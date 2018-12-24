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
    public class Race
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Distance { get; set; }
        public virtual string Location { get; set; }
        public virtual Country Country { get; set; }
        public virtual IList<Result> Results { get; set; }
        public Race()
        {

        }
    }
}

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
    public class Result
    {
        public virtual Athlete Athlete { get; set; }
        public virtual Race Race { get; set; }
        public virtual DateTime Registration { get; set; }
        public virtual TimeSpan Start { get; set; }
        public virtual TimeSpan Finish { get; set; }
        public virtual TimeSpan Gun_start { get; set; }
        public virtual decimal Time { get; set; }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public Result()
        {

        }
    }
}

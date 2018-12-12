using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2
{
    public class Result
    {
        public virtual int id_athlete { get; set; }
        public virtual int id_race { get; set; }
        public virtual DateTime registration { get; set; }
        public virtual DateTime start { get; set; }
        public virtual DateTime finish { get; set; }
        public virtual DateTime gun_start { get; set; }
        public virtual decimal time { get; set; }
        public Result()
        {

        }
    }
}

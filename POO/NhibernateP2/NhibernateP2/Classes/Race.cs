using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2
{
    public class Race
    {
        public virtual int id { get; set; }
        public virtual string name { get; set; }
        public virtual DateTime date { get; set; }
        public virtual string distance { get; set; }
        public virtual string location { get; set; }
        public virtual int id_Country { get; set; }
        public Race()
        {

        }
    }
}

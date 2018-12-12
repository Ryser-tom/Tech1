using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2
{
    public class Nationality
    {
        public virtual int id_Athlete { get; set; }
        public virtual int id_Country { get; set; }
        public Nationality()
        {

        }
    }
}

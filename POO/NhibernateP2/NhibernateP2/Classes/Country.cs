using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2
{
    public class Country
    {
        public virtual int id { get; set; }
        public virtual string code { get; set; }
        public virtual string name { get; set; }
        public Country()
        {

        }
    }
}

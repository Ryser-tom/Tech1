using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2
{
    public class Address
    {
        public virtual int id { get; set; }
        public virtual DateTime valid_from { get; set; }
        public virtual DateTime valid_to { get; set; }
        public virtual string street_nr { get; set; }
        public virtual string street { get; set; }
        public virtual string postal_code { get; set; }
        public virtual string location { get; set; }
        public virtual string country { get; set; }
        public Address()
        {

        }
    }
}

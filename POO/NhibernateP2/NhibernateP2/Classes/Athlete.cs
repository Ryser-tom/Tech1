using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2
{
    public class Athlete
    {
        public virtual int id { get; set; }
        public virtual string first { get; set; }
        public virtual string last { get; set; }
        public virtual DateTime birth { get; set; }
        public virtual string pass_hash { get; set; }
        public virtual string pass_salt { get; set; }
        public virtual string pass_hash_algo { get; set; }
        public virtual int deleted { get; set; }
        public Athlete()
        {

        }
    }
}

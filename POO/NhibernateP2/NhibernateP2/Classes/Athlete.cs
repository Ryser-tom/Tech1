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
        public virtual ISet<Email> email { get; set; }
        public Athlete()
        {

        }

        public Athlete(string first, string last, DateTime birth, string pass_hash, string pass_salt, string pass_hash_algo, int deleted)
        {
            this.first = first;
            this.last = last;
            this.birth = birth;
            this.pass_hash = pass_hash;
            this.pass_salt = pass_salt;
            this.pass_hash_algo = pass_hash_algo;
            this.deleted = deleted;
        }
    }
}

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
    public class Athlete
    {
        public virtual int Id { get; set; }
        public virtual string First { get; set; }
        public virtual string Last { get; set; }
        public virtual DateTime Birth { get; set; }
        public virtual string Pass_hash { get; set; }
        public virtual string Pass_salt { get; set; }
        public virtual string Pass_hash_algo { get; set; }
        public virtual int Deleted { get; set; }
        public virtual IList<Email> Emails { get; set; }
        public virtual IList<Result> Results { get; set; }
        public virtual ISet<Address> Addresses { get; set; }
        public virtual IList<Country> Nationalities { get; set; }
        public Athlete()
        {

        }

        public Athlete(string first, string last, DateTime birth, string pass_hash, string pass_salt, string pass_hash_algo, int deleted)
        {
            this.First = first;
            this.Last = last;
            this.Birth = birth;
            this.Pass_hash = pass_hash;
            this.Pass_salt = pass_salt;
            this.Pass_hash_algo = pass_hash_algo;
            this.Deleted = deleted;
        }
    }
}

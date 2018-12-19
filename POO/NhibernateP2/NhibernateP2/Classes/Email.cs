using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2
{
    public class Email
    {

        public virtual int Id { get; set; }
        public virtual string EmailText { get; set; }
        public virtual string Challenge { get; set; }
        public virtual int Verified { get; set; }
        public virtual Athlete AthleteOfEmail { get; set; }

        public Email()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateP2.map
{
    public class Address
    {
        private int id;
        private DateTime valid_from ;
        private DateTime valid_to;
        private string street_nr;
        private string street;
        private string postal_code;
        private string location;
        private string country;
        private int athlete;

        public virtual int Id { get => id; set => id = value; }
        public virtual DateTime Valid_from { get => valid_from; set => valid_from = value; }
        public virtual DateTime Valid_to { get => valid_to; set => valid_to = value; }
        public virtual string Street_nr { get => street_nr; set => street_nr = value; }
        public virtual string Street { get => street; set => street = value; }
        public virtual string Postal_code { get => postal_code; set => postal_code = value; }
        public virtual string Location { get => location; set => location = value; }
        public virtual string Country { get => country; set => country = value; }
        public virtual int Athlete { get => athlete; set => athlete = value; }
    }
}

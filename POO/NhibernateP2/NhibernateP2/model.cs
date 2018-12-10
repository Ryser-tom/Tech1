using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace NhibernateP2
{
    public class model
    {
        public string Test()
        {
            try {

                IList<map.Address> addresses;
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession()) {
                    addresses = session.QueryOver<map.Address>().Where(x => x.Id > 1).List();
                    session.Close();
                }
                factory.Close();

                return addresses[0].Street.ToString();

            } catch (Exception ex) {

                return ex.Message;
            }
        }
        public int Addition(int a, int b)
        {
            return a + b;
        }
    }
}

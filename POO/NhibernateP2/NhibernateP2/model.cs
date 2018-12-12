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
                IList<Address> addresses;
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession()) {
                    addresses = session.QueryOver<Address>().Where(x => x.id > 1).List();
                    session.Close();
                }
                factory.Close();

                return addresses[0].street.ToString();

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

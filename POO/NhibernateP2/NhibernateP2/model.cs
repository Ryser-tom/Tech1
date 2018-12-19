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
        public IList<Athlete> GetAthletes()
        {

            try {
                IList<Athlete> Athletes;
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession()) {
                    Athletes = session.QueryOver<Athlete>().Where(x => x.deleted == 0).List();
                    session.Close();
                }
                factory.Close();
                return Athletes;

            } catch (Exception ex) {
                throw(ex);
            }
        }
        public IList<Email> GetEmails(Athlete Athlete)
        {

            try {
                IList<Email> Emails;
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession()) {
                    Emails = session.QueryOver<Email>().Where(x => x.AthleteOfEmail == Athlete).List();
                    session.Close();
                }
                factory.Close();
                return Emails;

            } catch (Exception ex) {
                throw (ex);
            }
        }
        public void DeleteAthlete(Athlete Athlete)
        {
            Athlete.deleted = 1;
            try {
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession()) {
                    using (ITransaction transaction = session.BeginTransaction()) { 
                        session.Update(Athlete);
                    transaction.Commit();
                    session.Close();
                    }
                }
                factory.Close();

            } catch (Exception ex) {
                throw (ex);
            }
        }
    }
}

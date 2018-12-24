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
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace NhibernateP2
{
    public class model
    {
        public IList<Athlete> GetAthletes()
        {

            try {
                IList<Athlete> Athletes;
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession()) {
                    Athletes = session.QueryOver<Athlete>().Where(x => x.Deleted == 0).List();
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
                    Emails = session.QueryOver<Email>().Where(x => x.Athlete == Athlete).List();
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
            Athlete.Deleted = 1;
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
        public IList<Result> GetResults(Athlete A)
        {
            try
            {
                IList<Result> Results;
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession())
                {
                    Results = session.QueryOver<Result>().Where(x => x.Athlete == A).List();
                    session.Close();
                }
                factory.Close();
                return Results;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        
        public void CreateOrUpdateAthlete(Athlete athlete)
        {
            try
            {
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.SaveOrUpdate(athlete);
                        transaction.Commit();
                    }
                    session.Close();
                }
                factory.Close();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        /// <summary>
        /// update addresse if it exist or insert it if not
        /// </summary>
        /// <param name="Address"> object of type address with the address we want to update or create </param>
        public void CreateOrUpdateAddress(Address Address)
        {
            try
            {
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.SaveOrUpdate(Address);
                        transaction.Commit();
                    }
                    session.Close();
                }
                factory.Close();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public void DeleteAdress(Address Address)
        {
            try
            {
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(Address);
                        transaction.Commit();
                    }
                    session.Close();
                }
                factory.Close();

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        public IList<Country> GetCountry()
        {

            try
            {
                IList<Country> Country;
                ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
                using (ISession session = factory.OpenSession())
                {
                    Country = session.QueryOver<Country>().List();
                    session.Close();
                }
                factory.Close();
                return Country;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}

using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;

namespace NhibernateP2.Manager
{
    class Create
    {
        private ISession _session;
        private ISessionFactory _factory;
        private ITransaction _transaction;

        private ISession Session { get => _session; set => _session = value; }
        public ISessionFactory Factory { get => _factory; set => _factory = value; }
        public ITransaction Transaction { get => _transaction; set => _transaction = value; }

        public Create()
        {
            ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
        }

        public void CreateAthlete(string first, string last, DateTime birth, string pass_hash, string pass_salt, string pass_hash_algo)
        {
            Session = Factory.OpenSession();
            Athlete a = new Athlete(first, last, birth, pass_hash, pass_salt, pass_hash_algo, 0);
            Transaction = Session.BeginTransaction();
            Session.Save(a);
            Transaction.Commit();
        }
    }
}

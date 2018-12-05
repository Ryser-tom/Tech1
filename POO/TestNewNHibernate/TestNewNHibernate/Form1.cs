using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestNewNHibernate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHQL_Click(object sender, EventArgs e)
        {
            IList<Site> sites;
            ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            using (ISession session = factory.OpenSession())
            {
                // HQL
                sites = session.CreateQuery("from Site s where s.id > 1").List<Site>();
                                
                showSite(sites[0]);

                session.Close();
            }
            factory.Close();
        }

        private void btnCriteria_Click(object sender, EventArgs e)
        {
            IList<Site> sites;
            ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            using (ISession session = factory.OpenSession())
            {                
                // Criteria
                sites = session.CreateCriteria(typeof(Site)).Add(Restrictions.Gt("Id", 1)).List<Site>();
                
                showSite(sites[0]);

                session.Close();
            }
            factory.Close();
        }

        private void btnQueryOver_Click(object sender, EventArgs e)
        {
            IList<Site> sites;
            ISessionFactory factory = new NHibernate.Cfg.Configuration().Configure().BuildSessionFactory();
            using (ISession session = factory.OpenSession())
            {                
                // QueryOver
                sites = session.QueryOver<Site>().Where(x => x.Id > 1).List();

                showSite(sites[0]);

                session.Close();
            }
            factory.Close();
        }

        private void showSite(Site s)
        {
            label1.Text = s.Urls.Count() + " elements";
            textBox1.Text = s.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
        }
    }
}

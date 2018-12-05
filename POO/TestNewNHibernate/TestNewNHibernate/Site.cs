using System.Collections.Generic;

namespace TestNewNHibernate
{
    public class Site
    {
        private int id;
        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        private ISet<SiteUrl> urls { get; set; } = new HashSet<SiteUrl>();
        public virtual ISet<SiteUrl> Urls
        {
            get { return urls; }
            set { urls = value; }
        }
    }
}

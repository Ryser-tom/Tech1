namespace TestNewNHibernate
{
    public class SiteUrl
    {
        private int urlid;
        public virtual int UrlId
        {
            get { return urlid; }
            set { urlid = value; }
        }

        private string url;
        public virtual string Url
        {
            get { return url; }
            set { url = value; }
        }

        private Site site;
        public virtual Site Site
        {
            get { return site; }
            set { site = value; }
        }
    }
}

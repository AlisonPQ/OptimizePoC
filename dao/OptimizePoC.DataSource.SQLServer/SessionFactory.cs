using NHibernate;
using NHibernate.Cfg;

namespace OptimizePoC.DataSource.SQLServer
{
    public abstract class SessionFactory
    {
        protected ISessionFactory sessionFactory;
        protected ISession session;

        public SessionFactory()
        {
            try
            {
                NHibernate.Cfg.Configuration cfg = new Configuration();
                cfg.AddAssembly("OptimizePoC.DataSource.SQLServer");

                sessionFactory = cfg.BuildSessionFactory();
                session = sessionFactory.OpenSession();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}

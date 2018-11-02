using ee.ls.Repository.Mappings.Factory;
using ee.Repository;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cache;


namespace ee.ls.Repository.Factory.Oracle
{
    public class OracleSessionFactoryBuilder : ISessionFactoryBuilder
    {
        private static readonly string DatabaseKey = "DB";

        private static bool isShowSql = true;
        public ISessionFactory CreateSessionFactory()
        {
            var persistenceConfigurer = OracleClientConfiguration.Oracle10
                .ConnectionString(c => c.FromConnectionStringWithKey(DatabaseKey))
                .Provider<NHibernate.Connection.DriverConnectionProvider>()
                .AdoNetBatchSize(100)
                .Driver<NHibernate.Driver.OracleClientDriver>();
            if (isShowSql)
            {
                persistenceConfigurer.ShowSql().FormatSql();
            }


            var nhConfig = Fluently.Configure()
                .Database(persistenceConfigurer)
                 .Cache(c => c.ProviderClass<HashtableCacheProvider>().UseSecondLevelCache())
                .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(RealAssembly).Assembly));

            return nhConfig.BuildSessionFactory();
        }
        public void Build(string para)
        {

        }
    }
}

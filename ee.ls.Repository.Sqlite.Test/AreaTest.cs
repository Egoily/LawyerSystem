
using ee.ls.Models.Entities;
using ee.ls.Repository.Factory.Sqlite;
using ee.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ee.ls.Repository.Sqlite.Test
{
    [TestClass()]
    public class AreaTest
    {
        static void Build()
        {
            SessionManager.Builder = new SqliteSessionFactoryBuilder();
        }
        [TestInitialize()]
        public void Initialize()
        {
            log4net.Config.XmlConfigurator.Configure();
            Build();
        }

        [TestMethod()]
        public void QueryAreaTest()
        {
            using (var session = SessionManager.GetConnection())
            {
                using (var repo = new NhRepository<Area>())
                {
                    var query = repo.Query(x=>x.AreaCode=="440000");

                    var list = query.ToList();
                }
            }
        }
    }
}
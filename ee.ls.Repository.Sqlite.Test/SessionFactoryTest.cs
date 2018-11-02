
using ee.ls.Models.Entities;
using ee.ls.Repository.Factory.Sqlite;
using ee.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ee.ls.Repository.Sqlite.Test
{
    [TestClass()]
    public class SessionFactoryTest
    {
        static void Build()
        {
            SessionManager.Builder = new SqliteSessionFactoryBuilder();
        }
        [TestInitialize()]
        public void Initialize()
        {
            log4net.Config.XmlConfigurator.Configure();
  
        }

        [TestMethod()]
        public void BuildTest()
        {
            Build();
        }
    }
}
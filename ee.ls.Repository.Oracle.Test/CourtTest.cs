
using ee.ls.Models.Entities;
using ee.ls.Repository.Factory.Oracle;
using ee.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace ee.ls.Repository.Oracle.Test
{
    [TestClass()]
    public class CourtTest
    {
        static void Build()
        {
            SessionManager.Builder = new OracleSessionFactoryBuilder();
        }
        [TestInitialize()]
        public void Initialize()
        {
            log4net.Config.XmlConfigurator.Configure();
            Build();
        }

        [TestMethod()]
        public void QueryTest()
        {
            using (var session = SessionManager.GetConnection())
            {
                using (var repo = new NhRepository<Court>())
                {
                    var query = repo.Query();

                    var list = query.ToList();
                }
            }
        }

        [TestMethod()]
        public void AddTest()
        {
            using (var session = SessionManager.GetConnection())
            {
                using (var repo = new NhRepository<Court>())
                {
                    repo.Create(new Court()
                    {
                        Id = 1,
                        Name = "a"
                    });

                }
            }
        }
        [TestMethod()]
        public void UpdateTest()
        {
            using (var session = SessionManager.GetConnection())
            {
                using (var repo = new NhRepository<Court>())
                {
                    var entity = repo.GetById(1);
                    if (entity != null)
                    {
                        entity.Name = "new-Name" + DateTime.Now;
                        repo.Update(entity);
                    }
                }
            }
        }
        [TestMethod()]
        public void DeleteTest()
        {
            using (var session = SessionManager.GetConnection())
            {
                using (var repo = new NhRepository<Court>())
                {
                    var entity = repo.GetById(3);
                    if (entity != null)
                    {
                        repo.Delete(entity);
                    }
                }
            }
        }

    }
}
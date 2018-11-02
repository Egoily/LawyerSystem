using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.Repository
{
    public interface ISessionFactoryBuilder
    {
        ISessionFactory CreateSessionFactory();
        void Build(string para);
    }
}

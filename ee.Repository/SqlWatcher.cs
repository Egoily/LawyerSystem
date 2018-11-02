using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ee.Repository
{
    public class SqlWatcher : EmptyInterceptor
    {
        public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql)
        {
            System.Diagnostics.Debug.WriteLine("sql语句:" + sql);
            return base.OnPrepareStatement(sql);
        }
    }
}

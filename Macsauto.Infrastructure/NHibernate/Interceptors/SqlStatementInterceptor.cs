using NHibernate;
using NHibernate.SqlCommand;

namespace Macsauto.Infrastructure.NHibernate.Interceptors
{
    using System;

    public class SqlStatementInterceptor : EmptyInterceptor
    {
        public override SqlString OnPrepareStatement(SqlString sql)
        {
            //Console.WriteLine(sql.ToString());

            return sql;
        }
    }
}
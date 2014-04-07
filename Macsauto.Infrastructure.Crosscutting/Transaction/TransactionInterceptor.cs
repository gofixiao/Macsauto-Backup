using Macsauto.Infrastructure.Helper.Extension;
using Macsauto.Infrastructure.NHibernate;
using NHibernate;

namespace Macsauto.Infrastructure.Crosscutting.Transaction
{
	using System;

	using Castle.DynamicProxy;

    public class TransactionInterceptor : IInterceptor
    {
        private ITransaction _transaction;

		public void Intercept (IInvocation invocation)
		{
		    var sessionFactories = NHibernateSessionManager.SessionFactories;
			var method = invocation.Method;
			var isTransactionScoped = method.IsDecoratedBy(typeof(TransactionAttribute));

			if (isTransactionScoped) {
			    foreach (var sessionFactory in sessionFactories)
			    {
			        var session = sessionFactory.GetSession();

			        _transaction = sessionFactory.GetSession().Transaction.IsActive 
                                ? _session.Transaction 
                                : _session.BeginTransaction();
			    }
			    _transaction = _session.Transaction;

				try {
					invocation.Proceed();

					_transaction.Commit();
				} catch (Exception) {
					_transaction.Rollback();

					throw;
				} finally {
					_transaction.Dispose();
				}
			}
		}
	}
}
using Macsauto.Infrastructure.Helper.Extension;
using NHibernate;

namespace Macsauto.Infrastructure.Crosscutting.Transaction
{
	using System;

	using Castle.DynamicProxy;

    public class TransactionInterceptor : IInterceptor
	{
		private readonly ISession _session;
		private ITransaction _transaction;

		public TransactionInterceptor (ISession session)
		{
			_session = session;
		}

		public void Intercept (IInvocation invocation)
		{
			var method = invocation.Method;
			var isTransactionScoped = method.IsDecoratedBy(typeof(TransactionAttribute));

			if (isTransactionScoped) {
				_transaction = _session.Transaction.IsActive 
                                ? _session.Transaction 
                                : _session.BeginTransaction();

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
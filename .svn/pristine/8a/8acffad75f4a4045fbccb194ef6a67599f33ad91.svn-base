using NHibernate;
using NHibernate.Exceptions;

namespace Macsauto.Infrastructure.NHibernate.Common
{
    using System;

    public static class TransactionalExtension
    {
        public static void DoTransactional(this ISession session, Action<ISession> action)
        {
            using (var tx = session.BeginTransaction())
            {
                action(session);

                try
                {
                    tx.Commit();
                }
                catch (GenericADOException ex)
                {
                    throw new ApplicationException(@"Code is already used ", ex);
                }
            }

            //var branchSession = NHibernateSessionManager.GetBranchSession();

            //if (branchSession == null) return;

            //using (var tx = branchSession.BeginTransaction())
            //{
            //    action(branchSession);

            //    tx.Commit();

            //    branchSession.Clear();
            //}
        }
    }
}
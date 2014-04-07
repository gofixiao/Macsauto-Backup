using Macsauto.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.Common
{
    using System;
    using System.Globalization;
    using Macsauto.Domain.Contract;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Service;

    public class EntityCodeFactory
    {
        public static Entity GenerateCode(Entity entity)
        {
            var entityType = entity.GetType().ToString();

            if (entity as StockMovement != null)
            {
                var x = entity as StockMovement;

                entity.Code = string.Format(@"MVM/{0}/{1:yyMMdd}/{2:000}", 
                    (int)x.Type, 
                    DateTime.Now,
                    GetNewDailyIndexOf<StockMovement>());
            }
            else if (entity as Payment != null)
            {
                var x = entity as Payment;

                entity.Code = string.Format(@"PMT/{0}/{1:yyMMdd}/{2:000}",
                    (int)x.TenderType,
                    DateTime.Now,
                    GetNewDailyIndexOf<Payment>());
            }
            else if (entity as ServiceBooking != null)
            {
                entity.Code = string.Format(@"SBK/{0}/{1:yyMMdd}/{2}/{3:000}",
                    LoginService.LoggedInUserBranch.Code,
                    DateTime.Now,
                    GetNewMonthlyIndexOf<ServiceBooking>(),
                    GetNewDailyIndexOf<ServiceBooking>());
            }

            if (entity.Code == null || string.IsNullOrEmpty(entity.Code))
            {
                throw new ApplicationException(string.Format(@"No code format defined for entity type {0}", entityType));
            }

            return entity;
        }

        private static int GetNewDailyIndexOf<T>() where T : Entity
        {
            var session = NHibernateSessionManager.GetLocalSession();

            var entityNewIndex = session.CreateCriteria<T>()
                    .SetProjection(Projections.CountDistinct(@"Id"))
                    .Add(
                        Restrictions.Conjunction()
                            .Add(Restrictions.Gt(@"CreatedOn", DateTime.Today))
                            .Add(Restrictions.Lt(@"CreatedOn", DateTime.Today.AddDays(1).AddTicks(-1)))
                    ).UniqueResult<int>() + 1;

            return entityNewIndex;
        }

        private static int GetNewMonthlyIndexOf<T>() where T : Entity, ITransaction
        {
            var childSession = NHibernateSessionManager.GetLocalSession().GetSession(EntityMode.Poco);

            var totalTransaction = childSession.CreateCriteria<T>()
                                                  .SetProjection(Projections.RowCount())
                                                  .Add(
                                                      Restrictions.Eq(
                                                          Projections.SqlFunction(@"Month", NHibernateUtil.Int32,
                                                                                  Projections.Property(@"CreatedOn")),
                                                          DateTime.Now.Month
                                                          )
                                                  ).UniqueResult<int>();

            return totalTransaction + 1;
        }
    }
}
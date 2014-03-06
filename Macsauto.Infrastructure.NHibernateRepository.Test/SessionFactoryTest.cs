using Macsauto.Infrastructure.NHibernate;

namespace Macsauto.Infrastructure.NHibernateRepository.Test
{
    using System;

    using Macsauto.Domain.Model.Common;
    using Macsauto.Domain.Model.Employee;
    using NUnit.Framework;

    [TestFixture]
    public class SessionFactoryTest
    {
        [Test]
        public void CanCreateSessionFactory()
        {
            Assert.IsNotNull(NHibernateSessionManager.GetSession());
        }

        [Test]
        public void CanInsertToDatabase()
        {
            using (var session = NHibernateSessionManager.GetSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        var samuel = new Employee()
                        {
                            FirstName = "Samuel",
                            MiddleName = "Adam",
                            LastName = "Suhendra",
                            Gender = Gender.Male,
                            BirthDate = new DateTime(1989, 12, 7),
                            HomeAddress = new Address("Jakarta", "11720", "Nusa Indah 3")
                        };

                        session.Save(samuel);

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                    finally
                    {
                        transaction.Dispose();
                    }
                }
            }
        }
    }
}

using Macsauto.Domain.Contract;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Payment
{
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class PaymentRepository : NHibernateRepository<Payment>, IPaymentRepository
    {
        private readonly IRepository<Payment> _repository;

        public PaymentRepository(IRepository<Payment> repository, ITransactionalRepository<Payment> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public Payment GetPaymentForTransaction(ITransaction transaction)
        {
            var criteria = DetachedCriteria.For<Payment>()
                                           .Add(Restrictions.Eq(@"TransactionCode", transaction.GetTransactionId()));

            return _repository.FindFirst(criteria);
        }
    }
}
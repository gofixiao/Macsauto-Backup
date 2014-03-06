using System.Windows.Forms;
using NHibernate.Criterion;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Customer
{
    using System;
    using System.Linq;
    using Macsauto.Domain.SalesModule;
    using Macsauto.Infrastructure.Connector.SmartCard;
    using Macsauto.Infrastructure.NHibernate.Contract;

    public class MembershipRegistrationRepository : NHibernateRepository<MembershipRegistration>, IMembershipRegistrationRepository
    {
        private readonly IRepository<MembershipRegistration> _repository;

        public MembershipRegistrationRepository(IRepository<MembershipRegistration> repository, ITransactionalRepository<MembershipRegistration> transactionalRepository) : base(repository, transactionalRepository)
        {
            _repository = repository;
        }

        public new MembershipRegistration Insert(MembershipRegistration membershipRegistration)
        {
            var cardReader = CardManager.CardReaders.FirstOrDefault();

            if (cardReader == null) throw new ApplicationException(@"Card reader is not ready");

            if (cardReader.SmartCard == null) throw new ApplicationException(@"Card is not ready");
            if (!string.IsNullOrEmpty(cardReader.GetCardBlockValue(1)) &&
                MessageBox.Show(@"Card is not empty. Overwrite?", @"Confirmation", MessageBoxButtons.YesNo) !=
                DialogResult.Yes)
            {
                throw new ApplicationException(@"Failed to update membership card");
            }

            cardReader.UpdateCardBlockValue(1, membershipRegistration.Customer.Membership.Code);

            return base.Insert(membershipRegistration);
        }

        public MembershipRegistration GetRegistrationOf(Customer customer)
        {
            var criteria = DetachedCriteria.For<MembershipRegistration>()
                .Add(Restrictions.Eq(@"Customer", customer));

            return _repository.FindFirst(criteria);
        }
    }
}

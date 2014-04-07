using Macsauto.Domain;
using NHibernate.Event;
using NHibernate.Persister.Entity;

namespace Macsauto.Infrastructure.NHibernate.Common
{
    using System;
    using Macsauto.Infrastructure.Service;

    public class EntityService : IPreInsertEventListener, IPreUpdateEventListener
    {
        private readonly Employee _actor = LoginService.LoggedInUser == null ? null : LoginService.LoggedInUser.Employee;

        public bool OnPreInsert(PreInsertEvent @event)
        {
            var entity = @event.Entity as Entity;

            if (entity == null)
            {
                return false;
            }

            Set(@event.Persister, @event.State, @"CreatedBy", _actor);
            Set(@event.Persister, @event.State, @"UpdatedBy", _actor);

            entity.CreatedBy = _actor;
            entity.UpdatedBy = _actor;

            return false;
        }

        public bool OnPreUpdate(PreUpdateEvent @event)
        {
            var entity = @event.Entity as Entity;

            if (entity == null)
            {
                return false;
            }

            Set(@event.Persister, @event.State, @"UpdatedBy", _actor);

            entity.UpdatedBy = _actor;

            return false;
        }

        private static void Set(IEntityPersister persister, object[] state, string propertyName, object value)
        {
            var index = Array.IndexOf(persister.PropertyNames, propertyName);

            if (index == -1)
                return;

            state[index] = value;
        }
    }
}
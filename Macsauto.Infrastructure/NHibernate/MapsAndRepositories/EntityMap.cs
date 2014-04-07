using Macsauto.Domain;
using NHibernate.Engine;
using NHibernate.Id;

namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories
{
    using System;
    using FluentNHibernate.Mapping;
    using Macsauto.Infrastructure.Helper.Extension;

    public abstract class EntityMap<T> : ClassMap<T> where T : Entity
    {
        protected EntityMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Custom(typeof(CustomIdGenerator));
            NaturalId()
                .Property(x => x.Code, "code");
            Map(x => x.CreatedOn);
            References(x => x.CreatedBy, "createdBy");
            Version(x => x.UpdatedOn);
            References(x => x.UpdatedBy, "updatedBy");
        }
    }

    internal class CustomIdGenerator : IIdentifierGenerator
    {
        public object Generate(ISessionImplementor session, object obj)
        {
            return Guid.NewGuid().ToShortGuid();
        }
    }
}
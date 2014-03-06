using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace Macsauto.Infrastructure.NHibernate.Conventions
{
    public class CascadeAllConvention : IHasOneConvention, IHasManyConvention, IReferenceConvention
    {
        public void Apply(IOneToOneInstance instance)
        {
            instance.Cascade.All();
        }

        public void Apply(IOneToManyCollectionInstance instance)
        {
            instance.Cascade.All();
            instance.Inverse();
        }

        public void Apply(IManyToOneInstance instance)
        {
            instance.Cascade.All();
        }
    }
}

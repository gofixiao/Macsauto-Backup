namespace Macsauto.Infrastructure.NHibernate.Conventions
{
    using System;

    using Macsauto.Infrastructure.Helper.Extension;

    using FluentNHibernate;
    using FluentNHibernate.Conventions;
    using FluentNHibernate.Conventions.Instances;
    using FluentNHibernate.MappingModel;

    public class ColumnNameConvention : ForeignKeyConvention,
        IPropertyConvention, 
        IIdConvention, 
        IVersionConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            if (instance.Property.IsNotNull())
            {
                instance.Column(instance.Property.Name.ToCamelCase());   
            }
        }

        public void Apply(IIdentityInstance instance)
        {
            instance.Column(@"id");
        }

        protected override string GetKeyName(Member property, Type type)
        {
            if (property == null)
            {
                return type.Name.ToCamelCase() + @"_id";
            }

            return property.Name.ToCamelCase() + @"_id";
        }

        public void Apply(IVersionInstance instance)
        {
            instance.Column(
                instance.Name.ToCamelCase()
            );
        }
    }
}
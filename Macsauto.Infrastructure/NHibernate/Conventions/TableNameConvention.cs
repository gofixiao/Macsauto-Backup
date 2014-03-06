namespace Macsauto.Infrastructure.NHibernate.Conventions
{
    using Macsauto.Infrastructure.Helper.Extension;

    using FluentNHibernate.Conventions;
    using FluentNHibernate.Conventions.Instances;

    public class TableNameConvention : IClassConvention, IJoinedSubclassConvention, IHasManyConvention
    {
        public string Prefix { get { return @"mai"; } }

        public void Apply(IClassInstance instance)
        {
            if (instance.TableName.IsNotNull())
            {
                instance.Table(
                    string.Format("`{0}_{1}s`", Prefix, instance.TableName.ToLower().Replace("`", ""))
                );
            }
        }

        public void Apply(IJoinedSubclassInstance instance)
        {
            if (instance.TableName.IsNotNull())
            {
                instance.Table(
                    string.Format("`{0}_{1}`", Prefix, instance.TableName.Replace("`", ""))
                );
            }            
        }

        public void Apply(IOneToManyCollectionInstance instance)
        {
            if (instance.TableName.IsNotNull())
            {
                instance.Table(
                    string.Format("`{0}_{1}`", Prefix, instance.TableName.Replace("`", ""))
                );
            }
        }
    }
}
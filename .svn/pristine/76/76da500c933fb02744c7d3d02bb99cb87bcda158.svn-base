namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Customer
{
    public class CustomerMap : EntityMap<Domain.SalesModule.Customer>
    {
        public CustomerMap()
        {
            Component(x => x.Name, n =>
                {
                    n.Map(x => x.Firstname);
                    n.Map(x => x.Middlename);
                    n.Map(x => x.Lastname);
                });
            Map(x => x.CellPhone);
            Map(x => x.Email);
            Map(x => x.Birthdate);
            References(x => x.Membership);
            Component(x => x.HomeAddress, m =>
                {
                    m.References(x => x.City);
                    m.Map(x => x.Zipcode);
                    m.Map(x => x.AddressLine);
                });
            HasMany(x => x.VehicleRegistrations)
                .KeyColumn(@"registeredTo_id");
        }
    }
}
namespace Macsauto.Infrastructure.NHibernate.MapsAndRepositories.Employee
{
    public class EmployeeMap : EntityMap<Domain.UserManagementModule.Employee>
    {
        public EmployeeMap()
        {
            Component(x => x.Name, n =>
            {
                n.Map(x => x.Firstname);
                n.Map(x => x.Middlename);
                n.Map(x => x.Lastname);
            });
            Map(x => x.Birthdate);
            Map(x => x.Gender);
            Map(x => x.Position);
            Map(x => x.CellPhone);
            Map(x => x.Email);
            References(x => x.Branch);
            Component(x => x.HomeAddress, m =>
                {
                    m.References(x => x.City);
                    m.Map(x => x.Zipcode);
                    m.Map(x => x.AddressLine);
                });
        }
    }
}
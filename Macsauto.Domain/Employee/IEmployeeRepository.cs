using System.Collections.Generic;
using Macsauto.Domain.Contract;

namespace Macsauto.Domain
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IList<Employee> GetAllInBranch(Branch branch);
    }
}
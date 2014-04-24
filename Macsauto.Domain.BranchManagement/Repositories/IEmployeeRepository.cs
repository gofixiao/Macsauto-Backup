using System.Collections.Generic;
using Macsauto.Domain.BranchManagement.Entities;

namespace Macsauto.Domain.BranchManagement.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IList<Employee> GetAllInBranch(Branch branch);
    }
}
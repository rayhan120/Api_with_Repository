using apicore.Models;
using EF.Core.Repository.Interface.Repository;

namespace apicore.interfaceEmployee.RepositoryEmployee
{
    public interface IEmployeeRepository :ICommonRepository<Employee>
    {
    }
}

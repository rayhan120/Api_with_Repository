using apicore.Context;
using apicore.interfaceEmployee.RepositoryEmployee;
using apicore.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace apicore.Repository
{
    public class EmployeeRepository : CommonRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

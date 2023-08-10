using apicore.Context;
using apicore.interfaceEmployee.ManagerEmployee;
using apicore.Models;
using apicore.Repository;
using EF.Core.Repository.Interface.Repository;
using EF.Core.Repository.Manager;

namespace apicore.Manager
{
    public class EmployeeManager : CommonManager<Employee>, IEmployeeManager
    {
        public EmployeeManager(ApplicationDbContext _dbContext) : base(new EmployeeRepository(_dbContext))
        {
        }

        public Employee GetById(int id)
        {

            return GetFirstOrDefault(x => x.Id == id);
        }
    }
}

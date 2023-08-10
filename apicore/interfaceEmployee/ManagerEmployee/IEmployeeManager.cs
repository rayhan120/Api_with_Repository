using apicore.Context;
using apicore.Models;
using apicore.Repository;
using EF.Core.Repository.Interface.Manager;

namespace apicore.interfaceEmployee.ManagerEmployee
{
    public interface IEmployeeManager : ICommonManager<Employee>
    {

        Employee GetById(int id);
    }

}

   



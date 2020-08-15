using EmployeeManagment.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Data.Repositories.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        EmployeePositions GetCurrentPosition(int id);
    }
}

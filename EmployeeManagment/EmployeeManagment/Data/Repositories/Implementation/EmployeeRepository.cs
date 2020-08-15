using EmployeeManagment.Data.Contexts;
using EmployeeManagment.Data.Models;
using EmployeeManagment.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Data.Repositories.Implementation
{
    public class EmployeeRepository  : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationContext context) : base(context)
        {

        }
        public EmployeePositions GetCurrentPosition(int id)
        {
            return _context.Set<Employee>()
               .Include(e => e.EmployeePositions)
               .ThenInclude(e => e.Position).FirstOrDefault(e => e.Id == id).EmployeePositions.OrderByDescending(p => p.HireDate).FirstOrDefault();
        }
    }
}

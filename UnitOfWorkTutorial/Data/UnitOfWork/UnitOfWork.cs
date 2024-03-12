using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkTutorial.Data.Repository;
using UnitOfWorkTutorial.Entities;

namespace UnitOfWorkTutorial.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private UoWContext context;
        public IRepository<Employee> EmployeeRepository { get; private set; }
        public IRepository<Department> DepartmentRepository { get; private set; }

        public UnitOfWork(UoWContext _context)
        {
            context = _context;
            EmployeeRepository = new Repository<Employee>(context);
            DepartmentRepository = new Repository<Department>(context);
        }
        public int Commit()
        {
            return context.SaveChanges();
        }
    }
}

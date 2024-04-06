using DatabaseContext;
using Modelss;
using Modelss.ViewModels;
using Repositoris.Base;
using Repositoris.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositoris
{
  
    public class EmployeeRepository : Repositorie<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(CustomDbContext repositoryContext) : base(repositoryContext)
        {
        }

        public ICollection<SpEmployeeInfo> GetSpEmployeeInfo()
        {
            return db.GetSpEmployeeInfo();
        }
        public ICollection<SpEmployeeInfo> GetSpEmployeeInfoID(int id)
        {
            return db.GetSpEmployeeInfoID(id);
        }
    }
}

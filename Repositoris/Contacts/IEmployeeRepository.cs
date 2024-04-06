using Modelss;
using Modelss.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositoris.Contacts
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        ICollection<SpEmployeeInfo> GetSpEmployeeInfo();
        ICollection<SpEmployeeInfo> GetSpEmployeeInfoID(int id);
    }
}

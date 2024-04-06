using BLL_Manager.Base;
using BLL_Manager.Contact;
using Modelss;
using Modelss.ViewModels;
using Repositoris.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Manager
{
    public class EmployeeManager : Manager<Employee>, IEmployeeManager
    {
        IEmployeeRepository employeeRepository;
        public EmployeeManager(IEmployeeRepository _employeeRepository) : base(_employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        public ICollection<SpEmployeeInfo> GetSpEmployeeInfo()
        {
            return employeeRepository.GetSpEmployeeInfo();
        }

        public ICollection<SpEmployeeInfo> GetSpEmployeeInfoID(int id)
        {
            return employeeRepository.GetSpEmployeeInfoID(id);
        }
    }
}

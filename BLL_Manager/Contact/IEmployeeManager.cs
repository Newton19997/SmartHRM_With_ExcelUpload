using Modelss;
using Modelss.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Manager.Contact
{
   public interface IEmployeeManager : IManager<Employee>
    {
        public ICollection<SpEmployeeInfo> GetSpEmployeeInfo();
        ICollection<SpEmployeeInfo> GetSpEmployeeInfoID(int id);
    }
}

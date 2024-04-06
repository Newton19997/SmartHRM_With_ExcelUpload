using BLL_Manager.Base;
using BLL_Manager.Contact;
using Modelss;
using Repositoris.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Manager
{
  public  class ExcelManager: Manager<MExcelFile>, IExcelManager
    {
        IExcelRepository excelRepository;
        public ExcelManager(IExcelRepository _excelRepository) : base(_excelRepository)
        {
            excelRepository = _excelRepository;
        }
    }



}

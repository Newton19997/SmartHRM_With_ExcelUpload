using DatabaseContext;
using Modelss;
using Repositoris.Base;
using Repositoris.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositoris
{
    public class ExcelRepository: Repositorie<MExcelFile>, IExcelRepository
    {
        public ExcelRepository(CustomDbContext repositoryContext) : base(repositoryContext)
        {
        }

    }
}

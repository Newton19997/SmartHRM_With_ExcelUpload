using DatabaseContext;
using Modelss.ViewModels;
using Repositoris.Base;
using Repositoris.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositoris
{
   public class SampleRepository : Repositorie<Sample>, ISampleRepository
    {
        public SampleRepository(CustomDbContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}

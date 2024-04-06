using BLL_Manager.Base;
using BLL_Manager.Contact;
using Modelss.ViewModels;
using Repositoris.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Manager
{
   public class SampleManager : Manager<Sample>, ISampleManager
    {
        ISampleRepository sampleRepository;
        public SampleManager(ISampleRepository _sampleRepository) : base(_sampleRepository)
        {
            sampleRepository = _sampleRepository;
        }

    }
}

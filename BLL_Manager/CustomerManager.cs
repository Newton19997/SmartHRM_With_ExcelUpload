using BLL_Manager.Base;
using BLL_Manager.Contact;
using Modelss;
using Repositoris;
using Repositoris.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Manager
{
    public class CustomerManager:Manager<Customer>,ICustomerManager
    {
        ICustomerRepository customerRepository;
        public CustomerManager(ICustomerRepository _customerRepository) : base( _customerRepository)
        {
            customerRepository = _customerRepository;
        }
        /*
        public override bool Add(Customer customer)
        {
            // Logical opration
            //checking
            //policy related opration
            return customerRepository.Add(customer);
        }

        public override bool UpDate(Customer customer)
        {
            return customerRepository.UpDate(customer);
        }
        */
    }
}

using BLL_Manager.Contact;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Controllers
{
    public class POrderHeaderController : Controller
    {

        private ICustomerManager _customerManager;
        public POrderHeaderController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            PoHeader item = new PoHeader();
            item.PoDetails.Add(new PoDetail() { Id = 1 });
            //item.PoDetails.Add(new PoDetail() { Id = 2 });
            //item.PoDetails.Add(new PoDetail() { Id = 3 });
            ViewBag.CustomerList = GetCustomer();

            return View(item);
        }


        private List<SelectListItem> GetCustomer()
        {
            var lisCustomer = new List<SelectListItem>();
            lisCustomer = _customerManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.CustomerName
            }).ToList();
            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "-----Select Customer-----"
            };
            lisCustomer.Insert(0, defItem);


            return lisCustomer;
        }

    }
}

using BLL_Manager.Contact;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Modelss;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace WebApp2.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerManager _customerManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CustomerController(ICustomerManager customerManager, IWebHostEnvironment webHostEnvironment)
        {
            _customerManager = customerManager;
            // _customerManager = new CustomerManager();
            _webHostEnvironment = webHostEnvironment;
    }
        public ActionResult Index()
        {
            var model = _customerManager.GetAll();

            return View(model);
        }
        public IActionResult Create()
        {
            //return "Myname is "+ custoner.CustomerName + " "+ custoner.Address + "";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer custoner)
        {

            if (ModelState.IsValid)
            {
                //for Customer start
              //string folder = "CustomerImage/";
              //  folder = Guid.NewGuid().ToString() + "_" + custoner.CoverImageUrl.FileName;
              //  //string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {

                        var file = Image;
                        var uploads = Path.Combine(_webHostEnvironment.WebRootPath, "CustomerImage/");

                        if (file.Length > 0)
                        {
                            var fileName = ContentDispositionHeaderValue.Parse
                                (file.ContentDisposition).FileName.Trim('"');

                            System.Console.WriteLine(fileName);
                            using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                            {
                               file.CopyToAsync(fileStream);
                                custoner.CoverImageUrl = file.FileName;
                            }


                        }
                    }
                }
                //for Customer end


                //db.Customers.Add(custoner);
                bool isSave = _customerManager.Add(custoner);
                if (isSave)
                {
                    // return RedirectToAction("Details", custoner);
                    return RedirectToAction(nameof(Index));
                }


            }
            else
            {

            }

            return View();
        }
        //public IActionResult Details(Customer custoner)
        //{
        //    return View(custoner);
        //}

        // GET: ShopController/Details/5
        public ActionResult Details(int id)
        {
            var shopeditload = _customerManager.GetById(id);
            return View(shopeditload);
        }
        // GET: ShopController/Edit/5


        public ActionResult Edit(int id)
        {
            var shopeditload = _customerManager.GetById(id);

            return View(shopeditload);
        }

        // POST: ShopController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                var edited = _customerManager.UpDate(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopController/Delete/5
        public ActionResult Delete(int id)
        {
            var shopeditload = _customerManager.GetById(id);
            return View(shopeditload);
        }

        // POST: ShopController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                var deleted = _customerManager.Remove(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


    }
}

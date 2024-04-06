using BLL_Manager.Contact;
using Microsoft.AspNetCore.Mvc;
using Modelss;
using Modelss.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Controllers
{
    public class EmployeeController : Controller
    {

        private IEmployeeManager _employeeManager;
        public EmployeeController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
          
        }
        public ActionResult Index()
        {
            var model = _employeeManager.GetAll();

            return View(model);
        }
        public IActionResult Create()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {

            if (ModelState.IsValid)
            {
               
                bool isSave = _employeeManager.Add(employee);
                if (isSave)
                {
                  
                    return RedirectToAction(nameof(Index));
                }


            }
            else
            {

            }

            return View();
        }
       
        // GET: ShopController/Details/5
        public ActionResult Details(int id)
        {
            var shopeditload = _employeeManager.GetById(id);
            return View(shopeditload);
        }
        // GET: ShopController/Edit/5


        public ActionResult Edit(int id)
        {
            var shopeditload = _employeeManager.GetById(id);

            return View(shopeditload);
        }

        // POST: ShopController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee employee)
        {
            try
            {
                var edited = _employeeManager.UpDate(employee);
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
            var shopeditload = _employeeManager.GetById(id);
            return View(shopeditload);
        }

        // POST: ShopController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee employee)
        {
            try
            {
                var deleted = _employeeManager.Remove(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Report()
        {
            var model = _employeeManager.GetSpEmployeeInfo();

            return View(model);
        }

        [Route("api/Employee/EmployeeDetails")]
        public IEnumerable<SpEmployeeInfo> GetSpEmployeeInfoID(int Id)
        {
            var OrderDetailIDWise = _employeeManager.GetSpEmployeeInfoID(Id).ToList();
            return OrderDetailIDWise;
        }
    }
}

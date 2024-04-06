using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp2.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {

            Modelss.ViewModels.Sample obj;
            List<Modelss.ViewModels.Sample> lobj = new List<Modelss.ViewModels.Sample>();

            obj = new Modelss.ViewModels.Sample();
            obj.Id = 1;
            obj.SampleName = "DKNY JEANS";
            obj.Length ="78.90";
            obj.Width = "50.90";
            obj.price = "19";
            obj.SampleImg = "S1.gif";
            lobj.Add(obj);

            obj = new Modelss.ViewModels.Sample();
            obj.Id = 2;
            obj.SampleName = "AKIABARA";
            obj.Length = "40.90";
            obj.Width = "20.90";
            obj.price = "18.90";
            obj.SampleImg = "S2.gif";
            lobj.Add(obj);

            obj = new Modelss.ViewModels.Sample();
            obj.Id = 3;
            obj.SampleName = "JJXX JJXX";
            obj.Length = "50.70";
            obj.Width = "40.80";
            obj.price = "20.00";
            obj.SampleImg = "S3.png";
            lobj.Add(obj);

            obj = new Modelss.ViewModels.Sample();
            obj.Id = 4;
            obj.SampleName = "JACK$JONES";
            obj.Length = "120.00";
            obj.Width = "78.00";
            obj.price = "45.90";
            obj.SampleImg = "S5.png";
            lobj.Add(obj);

            return View(lobj);
        }
        public IActionResult OrderCreate()
        {
            return View();
        }

        }
}

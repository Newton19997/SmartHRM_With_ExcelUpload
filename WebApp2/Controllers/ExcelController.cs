using BLL_Manager.Contact;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using Modelss;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using WebApp2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp2.Controllers
{
    public class ExcelController : Controller
    {
        private IExcelManager _excelManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;
        private ICustomerManager _customerManager;
        public ExcelController(IExcelManager excelManager, IWebHostEnvironment webHostEnvironment , IConfiguration configuration, ICustomerManager customerManager)
        {
            _excelManager = excelManager;
            // _customerManager = new CustomerManager();
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
            _customerManager = customerManager;
        }
        public IActionResult Index()
        {
            var data = _excelManager.GetAll();        
            return View(data);
        }

        public IActionResult JQIndex()
        {
            return View();
        }
        public IActionResult GetCustomerList()
        {
            var data = _excelManager.GetAll();
            return new JsonResult(data);
        }


        public IActionResult ImportExcelFile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ImportExcelFile(IFormFile formfile)
        {
            try
            {
                if (formfile.FileName != "" && formfile.Length > 0)
                {
                    var mainPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UploadExcelFile");
                    if (!Directory.Exists(mainPath))
                    {
                        Directory.CreateDirectory(mainPath);
                    }
                    var filePath = Path.Combine(mainPath, formfile.FileName);
                    using (FileStream stream = new FileStream(filePath, FileMode.Create))
                    {
                        formfile.CopyTo(stream);
                    }
                    var fileName = formfile.FileName;
                    string extension = Path.GetExtension(fileName);
                    string conString = string.Empty;
                    switch (extension)
                    {
                        case ".xls":
                            conString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR-YES'";
                            break;
                        case ".xlsx":
                           // conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR-YES'";
                            conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=2\"";
                            break;
                    }
                    DataTable dt = new DataTable();
                    conString = string.Format(conString, filePath);
                    using (OleDbConnection conExcel = new OleDbConnection(conString))
                    {
                        using (OleDbCommand cmdExcel = new OleDbCommand())
                        {
                            using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                            {
                                cmdExcel.Connection = conExcel;
                                conExcel.Open();
                                DataTable dtExcelSchema = conExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                                string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                                cmdExcel.CommandText = "SELECT * FROM  [" + sheetName + "]";
                                odaExcel.SelectCommand = cmdExcel;
                                odaExcel.Fill(dt);
                                conExcel.Close();

                            }

                        }
                    }


                    //start
                    /*
                    MExcelFile mExcelFile = new MExcelFile();
                    foreach (DataRow dtRow in dt.Rows)
                    {

                        mExcelFile.CustomerCode =Int32.Parse(dtRow[0].ToString());
                        mExcelFile.FirstName = dtRow[1].ToString();
                        mExcelFile.LastName  = dtRow[2].ToString();
                        mExcelFile.Gender  = dtRow[3].ToString();
                        mExcelFile.Country = dtRow[4].ToString();
                        mExcelFile.Age = Int32.Parse(dtRow[5].ToString());
                       
                        //bool isSave = 
                           // _excelManager.Add(mExcelFile);
                        //if (isSave)
                        //{
                        //    // return RedirectToAction("Details", custoner);
                        //    return RedirectToAction(nameof(Index));
                        //}
                 
                    }
                       */

                    //foreach (var property in dt)
                    //{
                    //    cuAddress.Id = property.Id;
                    //    cuAddress.CustomerId = id;
                    //    cuAddress.Customer_Address = property.Customer_Address;

                    //    customerAddressManager.EditInsert_CustomerAddresss(id, property.Customer_Address, 1);

                    //}
                    //end

                    string dbconString = _configuration.GetConnectionString("DefaultConnection");
                     using(SqlConnection con =new SqlConnection(dbconString))
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                        {
                            sqlBulkCopy.DestinationTableName = "MExcelFiles";
                            sqlBulkCopy.ColumnMappings.Add("CustomerCode", "CustomerCode");
                            sqlBulkCopy.ColumnMappings.Add("FirstName", "FirstName");
                            sqlBulkCopy.ColumnMappings.Add("LastName", "LastName");
                            sqlBulkCopy.ColumnMappings.Add("Gender", "Gender");
                            sqlBulkCopy.ColumnMappings.Add("Country", "Country");
                            sqlBulkCopy.ColumnMappings.Add("Age", "Age");
                            con.Open();
                            sqlBulkCopy.WriteToServer(dt);
                            con.Close();

                        }

                    }


                }

                // ViewBag.message = "File Import Successfull, Data Save into Database.";
                TempData["message"] = "File Import Successfull, Data Save into Database.";
                return RedirectToAction("Index");

            }
            catch (Exception ex )
            {

                //  throw ex;
                string msg = ex.Message;
            }

            
            //conString=cofiguration

            return View();

            //if (ModelState.IsValid)
            //{
            //    OrderDetail orderDetail = new OrderDetail();
            //    //orderDetail.Id = model.Id;
            //    orderDetail.OrderId = model.id;
            //    orderDetail.ProductId = model.ProductId;
            //    orderDetail.Qty = model.Qty;
            //    orderDetail.UnitPrice = model.UnitPrice;
            //    orderDetail.DiscountPercentage = model.DiscountPercentage;



            //    var IsAdded = orderdetailsManager.Add(orderDetail);
            //    if (IsAdded)
            //    {
            //        return Ok(orderDetail);
            //        //return Ok(product);
            //    }
            //}
            //return Ok();

        }

        public IActionResult ExportExcel()
        {
            try
            {
                var data = _excelManager.GetAll();
                if(data !=null & data.Count > 0)
                {
                  //  using(xlworkbook)
                   

                }
                TempData["Error"] = "Data Not Found";

            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }
            return RedirectToAction("JQIndex");
        }


        //fordropdown list
        public IActionResult Drop()
        {
         

            DropModel lcn = new DropModel();
           // var data = _excelManager.GetAll().ToList();
            lcn.Customers = _customerManager.GetAll().Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.CustomerName
            }).ToList();


           
            return View(lcn);
        }

    }
}

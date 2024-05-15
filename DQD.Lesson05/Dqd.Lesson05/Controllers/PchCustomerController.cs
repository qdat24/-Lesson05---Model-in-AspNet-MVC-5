using Pch.Lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Pch.Lesson05.Controllers
{
    public class PchCustomerController : Controller
    {
        // GET: PchCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: PchCustomerDetail
        public ActionResult PchCustomerDetail() 
        {
            //Tạo đối tượng dữ liệu
            var customer = new PchCustomer()
            {
                CustomerID = 1,
                FirstName = "Phạm Công",
                LastName = "Hiếu",
                Address = "K22CNT3",
                YearOfBirth = 2001
            };
            ViewBag.customer = customer;
            return View();
        }

        //Get: PchListCustomer
        public ActionResult PchListCustomer()
        {
            var list = new List<PchCustomer>()
            {
                    new PchCustomer()
        {
            CustomerID = 1,
                FirstName = "Phạm Công",
                LastName = "Hiếu",
                Address = "K22CNT3",
                YearOfBirth = 2001
        },
               new PchCustomer()
        {
            CustomerID = 2,
                FirstName = "Bùi Sơn",
                LastName = "Tùng",
                Address = "K22CNT3",
                YearOfBirth = 2000
                },
               new PchCustomer()
        {
            CustomerID = 3,
                FirstName = "Bùi Sơn",
                LastName = "Tùng 1",
                Address = "K22CNT3",
                YearOfBirth = 2004
                },
               new PchCustomer()
        {
            CustomerID = 4,
                FirstName = "Phạm Công",
                LastName = "Hiếu 1",
                Address = "K22CNT3",
                YearOfBirth = 2004
                }
            };
            //ViewBag.list = list; //Đưa dữ liệu ra view bằng đối tượng ViewBag

            return View(list); 
        }
    }
}
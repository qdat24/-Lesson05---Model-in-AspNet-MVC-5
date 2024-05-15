using Pch.Lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Pch.Lesson05.Controllers
{
    public class PchCustomerScaffdingController : Controller
    {
        //mocdata
        private static List<PchCustomer> listCustomer = new List<PchCustomer>()
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
    // GET: PchCustomerScaffding
    // listcustomer
    public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult PchCreate()
        {
            var model = new PchCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult PchCreate(PchCustomer model)
        {
            //thêm mới đối tượng kh ách hàng bào ds dữ liệu
             listCustomer.Add(model);
            //return View(model);
            //Chuyển về trang danh sách
            return RedirectToAction("Index");
        }

        public ActionResult PchEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(customer);
        }
    }
}
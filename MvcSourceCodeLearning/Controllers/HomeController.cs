using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSourceCodeLearning.Models;

namespace MvcSourceCodeLearning.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {  
            /*ViewBag.Message = "Welcome to ASP.NET MVC!";*/
            return View();
        }

        public ActionResult About()
        {
            throw new HttpException(500, "test");
            
            return View();
        }

        public ActionResult PersonContact()
        {
            Contact contact = new Contact();
            contact.Name = "Vincent";
            contact.Phone = "61416776690";
            contact.EmailAddress="mscsharp@gmail.com";
            contact.Address = new Address();
            contact.Address.Address1 = "365 pakuranga rd";
            contact.Address.Suburb = "Pakuranga";
            contact.Address.Country = "NZ";
            return View(contact);
        }

        public ActionResult EditEmployee() {
            Employee employee = new Employee
            {
                DateBirth = new DateTime(1980,8,24),
                Department = "Sales",
                Gender = "Male",
                Name = "Vincent"            
            };

            return View(employee);
        }
    }
}

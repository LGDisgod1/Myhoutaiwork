using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "hello wrold";
        }
        public Cusromer getCusromer()
        {
            Cusromer co = new Cusromer();
            co.CustomerName = "abc";
            co.Address = "def";
            return co;
        }
        public ActionResult GetView()
        {
            string greeting;
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;

            if (hour < 12)
            {
                greeting = "早上好";
            }
            else
            {
                greeting = "下午好";
            }

             //ViewData["greeting"] = greeting;
            ViewBag.greeting = greeting;
            //Customer emp = new Customer();
            Employee yee = new Employee();
            yee.Name = "李四";
            yee.Salary = 20000;
            Customer ct = new Customer();
            ViewData["Custkey"] = ct;
            ct.CustomerNmae = "顾客A";
            ct.Address = "南宁";
            //ViewData["Empkey"] = emp;
            ViewBag.Empkey = yee;
            return View(yee);


        }
    }
}
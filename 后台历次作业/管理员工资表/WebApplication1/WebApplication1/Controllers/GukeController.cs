using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GukeController : Controller
    {
        // GET: Guke
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
            //ViewData["greeting"] = greeting;
            ViewBag.greeting = greeting;
            //Customer emp = new Customer();
            Employee yee = new Employee();
            yee.Name = "里顾";
            yee.Salary = 20000;
            Customer ct = new Customer();
            ViewData["Custkey"] = ct;
            ct.CustomerNmae = "顾客A";
            ct.Address = "嗯呐";
            //ViewData["Empkey"] = emp;
            ViewBag.Empkey = yee;
            return View(yee);

        }
    }
}
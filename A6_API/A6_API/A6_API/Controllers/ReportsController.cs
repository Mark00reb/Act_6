using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A6_API.Models;

namespace A6_API.Controllers
{
   // [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class ReportsController : Controller
    {
        [System.Web.Mvc.Route("api/Reports/getReportData")]
        [HttpGet]

        public dynamic getReportData(int quarter)
        {
            SalesDB_A6Entities db = new SalesDB_A6Entities();
            db.Configuration.ProxyCreationEnabled = false;
            int E1_sales;
            //int E2_sales;
            //int E3_sales;

            if (quarter == 1)
            {
                E1_sales = db.Sales.Where(x => x.Sale_Quarter == 1).Where(x=>x.Emp_ID == 1).Count();
              //  E2_sales = db.Sales.Where(x => x.Sale_Quarter == 1).Where(x => x.Emp_ID == 2).Count();
              //  E3_sales = db.Sales.Where(x => x.Sale_Quarter == 1).Where(x => x.Emp_ID == 3).Count();
            }
            else if (quarter == 2)
                {
                E1_sales = db.Sales.Where(x => x.Sale_Quarter == 2).Where(x => x.Emp_ID == 1).Count();
              //  E2_sales = db.Sales.Where(x => x.Sale_Quarter == 2).Where(x => x.Emp_ID == 2).Count();
              //  E3_sales = db.Sales.Where(x => x.Sale_Quarter == 2).Where(x => x.Emp_ID == 3).Count();
            }
            else if (quarter == 3)
            {
                E1_sales = db.Sales.Where(x => x.Sale_Quarter == 3).Where(x => x.Emp_ID == 1).Count();
              //  E2_sales = db.Sales.Where(x => x.Sale_Quarter == 3).Where(x => x.Emp_ID == 2).Count();
              //  E3_sales = db.Sales.Where(x => x.Sale_Quarter == 3).Where(x => x.Emp_ID == 3).Count();
            }
            else 
            {
                E1_sales = db.Sales.Where(x => x.Sale_Quarter == 4).Where(x => x.Emp_ID == 1).Count();
               // E2_sales = db.Sales.Where(x => x.Sale_Quarter == 4).Where(x => x.Emp_ID == 2).Count();
               // E3_sales = db.Sales.Where(x => x.Sale_Quarter == 4).Where(x => x.Emp_ID == 3).Count();
            }

            return getReportData(E1_sales/*, E2_sales, E3_sales*/);
        }

        //private dynamic getExpandedReport(int quarter)
        //{
        //    dynamic outObject = new ExpandoObject();
        //}

        //// GET: Reports
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}
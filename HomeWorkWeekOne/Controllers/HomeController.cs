using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWorkWeekOne.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /// <summary>
        /// 客戶資料管理
        /// </summary>
        /// <returns></returns>
        public ActionResult Customer()
        {
            return View();
        }

        /// <summary>
        /// 客戶聯絡人管理
        /// </summary>
        /// <returns></returns>
        public ActionResult ContactPerson()
        {
            return View();
        }

        /// <summary>
        /// 客戶銀行帳戶管理
        /// </summary>
        /// <returns></returns>
        public ActionResult Bank()
        {
            return View();
        }
    }
}
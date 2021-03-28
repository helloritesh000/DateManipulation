using BusinessLogic;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateManipulation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FormCollection formCollection)
        {
            string firstDate = formCollection["txtFirstOne"].ToString();
            string secondDate = formCollection["txtSecondDate"].ToString();

            if (IsValid(firstDate, secondDate))
            {

                SplittedDate date1 = new SplittedDate(Int32.Parse(firstDate.Split('/')[0]), Int32.Parse(firstDate.Split('/')[1]), Int32.Parse(firstDate.Split('/')[2]));
                SplittedDate date2 = new SplittedDate(Int32.Parse(secondDate.Split('/')[0]), Int32.Parse(secondDate.Split('/')[1]), Int32.Parse(secondDate.Split('/')[2]));

                DateBlComponent dateBlComponent = new DateBlComponent();
                int dateDifference = dateBlComponent.GetDateDifference(date1, date2);

                ViewBag.Message = "Difference between " + firstDate + " and " + secondDate + " is " + dateDifference + "days";
            }
            return View();
        }

        private bool IsValid(string firstDate, string secondDate)
        {
            if (string.IsNullOrEmpty(firstDate) || string.IsNullOrEmpty(secondDate))
            {
                ViewBag.Error = "Please select dates";
                return false;
            }
            return true;
        }
    }
}
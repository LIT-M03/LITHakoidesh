using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LITHakoidesh.Data;
using LITHakoidesh.Web.Models;

namespace LITHakoidesh.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new VisitsRepository(Properties.Settings.Default.LITConStr);
            repo.AddVisit(Request.UserHostAddress);
            var vm = new HomePageViewModel
            {
                FiveMostFrequentIPs = repo.GetFiveMostFrequentIPs(),
                TodayCount = repo.GetVisitCountForToday(),
                MostPopularIP = repo.GetMostPopularIpAddress()
            };
            return View(vm);
        }
    }


}

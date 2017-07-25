using SuyiRestApi.ATS;
using SuyiRestApi.ATS.AtsEntities;
using SuyiRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuyiRestApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public List<MenteeCandidateMatchModel> GetMenteeCandidateMatches()
        {
            var atsProvider = new AzureTableStorageProvider();

            var quarters = atsProvider.FetchEntities<QuarterEntity>("Quarter", TableType.Quarter);
            return new List<MenteeCandidateMatchModel>();
        }
    }
}

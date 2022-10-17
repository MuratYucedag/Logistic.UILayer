using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;

namespace Logistic.UILayer.Controllers
{
    public class MapController : Controller
    {
        DBLogisticEntities db = new DBLogisticEntities();
        public ActionResult Index()
        {
            var values = db.TblMap.ToList();
            return View(values);
        }
    }
}
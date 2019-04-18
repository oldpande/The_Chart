using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chart.Controllers
{
  public class DefaultController : Controller
  {
    // GET: Default
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult NewResult()
    {
      return View();
    }
  }
}
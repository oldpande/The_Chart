using Chart.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chart.Controllers
{
  public class HomeController : Controller
  {
    //public CoordinateData coordinateData = new CoordinateData();

    public ActionResult Index()
    {
      return View();
    }
    
    [HttpPost]
    public ActionResult Answer(double first_x, double second_x, double third_x, double step, double start_step, double finish_step)
    {
      //coordinateData.First_x = first_x;
      //coordinateData.Second_x = second_x;
      //coordinateData.Third_x = third_x;
      //coordinateData.Step = step;
      //coordinateData.Start_step = start_step;
      //coordinateData.Finish_step = finish_step;
      return View();
    }

    public JsonResult DataChart(double a, double b, double c, double Step, double RangeFrom, double RangeTo)
    {
      List<DataPoint> dataPoints = new List<DataPoint>();

      for (double x = RangeFrom; x <= RangeTo; x += Step)
      {
        double y = Math.Pow(a * x, 2) + (b * x) + c;
        dataPoints.Add(new DataPoint(x, y));
      }

      //JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
      return Json(dataPoints, JsonRequestBehavior.AllowGet);//Content(JsonConvert.SerializeObject(dataPoints, _jsonSetting), "application/json");//
    }
  }
}
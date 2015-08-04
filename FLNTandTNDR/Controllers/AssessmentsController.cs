using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FLNTandTNDR.Controllers
{
    public class AssessmentsController : Controller
    {
        Methods.AssessmentFunctions assessFunctions = new Methods.AssessmentFunctions();
        //
        // GET: /Assessments/
        public ActionResult Index()
        {
            return View();
        }
        [System.Web.Mvc.HttpGet]
        public string GetData(int dataValue)
        {
            var assessment = assessFunctions.GetData(dataValue);
            return assessment;
        }

	}
}
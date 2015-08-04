using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System.Web.Script.Serialization;

namespace FLNTandTNDR.Methods
{
    public class AssessmentFunctions
    {
        Models.AssessmentModel assessmentEntity = new Models.AssessmentModel();
        StandardFunctions stdFunctions = new StandardFunctions();
        public string GetData(int Value)
        {
            string path = string.Empty;
            switch (Value)
	{
	    case 1:
            path = "~/SiteContent/Assessment.json";
		break;
	    case 2:
        path = "~/SiteContent/Jobs.json";
		break;
	}
           
            string jsonPath = System.Web.HttpContext.Current.Server.MapPath(path);
            string jsonData = string.Empty;
            jsonData = stdFunctions.ReadFile(jsonPath);
            return jsonData;
        }
        public Models.AssessmentModel GetAssessment(int dataValue)
        {
            JavaScriptSerializer objJavascript = new JavaScriptSerializer();
            string rawJson = GetData(dataValue);
            Models.AssessmentModel testModels = objJavascript.Deserialize<Models.AssessmentModel>(rawJson);
            
            var data = JsonConvert.SerializeObject(rawJson);
            return testModels;
        }


    }
}
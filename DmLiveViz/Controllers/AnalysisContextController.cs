using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DmLiveViz.Code;
using DmLiveViz.Models;

namespace DmLiveViz.Controllers
{
    public class AnalysisContextController : Controller
    {
        private DmLiveUtilityDmLiveAnalysisDmLiveAnalysisContext2Context db = new DmLiveUtilityDmLiveAnalysisDmLiveAnalysisContext2Context();

        // GET: /AnalysisContext/Data
        public JsonNetResult Data(int? count)
        {
            if (!count.HasValue) count = 150;
            var d = db.Requests
                .Where( r => r.RequestType != "resource")
                .Take(count.Value).ToArray();
            return new JsonNetResult { Data = d, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        // GET: /AnalysisContext/Viz
        public ViewResult Viz()
        {
            return View();
        }
    }
}

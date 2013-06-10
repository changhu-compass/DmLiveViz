using System;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DmLiveViz.Code
{
    // Implementation based on
    // http://json.codeplex.com/discussions/347099    

    public class JsonNetResult : JsonResult
    {
        public JsonSerializerSettings SerializerSettings { get; set; }

        public JsonNetResult()
        {
            SerializerSettings = new JsonSerializerSettings();
            SerializerSettings.Converters.Add(new IsoDateTimeConverter());
            SerializerSettings.Converters.Add(new StringEnumConverter());
            SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            var response = context.HttpContext.Response;
            response.ContentType = !String.IsNullOrEmpty(ContentType) ? ContentType : "application/json";

            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            if (Data == null)
            {
                return;
            }

            var jsonText = JsonConvert.SerializeObject(Data, Formatting.Indented, SerializerSettings);
            response.Write(jsonText);
        }
    }
}
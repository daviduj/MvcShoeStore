using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShoesStore.Helpers
{
    public class JsonNetResult : JsonResult
    {
        public JsonSerializerSettings SerializerSettings { get; set; }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            var response = context.HttpContext.Response;

            response.ContentType = !String.IsNullOrEmpty(ContentType) ? ContentType : "application/json";

            if (ContentEncoding != null)
                response.ContentEncoding = ContentEncoding;

            if (Data == null)
                return;

            var serializedObject = JsonConvert.SerializeObject(
                Data,
                Newtonsoft.Json.Formatting.None,
                SerializerSettings ?? new JsonSerializerSettings() { DateTimeZoneHandling = DateTimeZoneHandling.Utc }
            );
            response.Write(serializedObject);
        }
    }
}
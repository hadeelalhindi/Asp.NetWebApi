using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Net.Http.Formatting;
using Microsoft.Ajax.Utilities;
using System.Net.Http.Headers;

namespace WebApplication
{
    public static class WebApiConfig
    {
      /*  public class TestJsonFormatter: JsonMediaTypeFormatter
        {
            public TestJsonFormatter()
            {
                this.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
            }
            public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
            {
                base.SetDefaultContentHeaders(type, headers, mediaType);
                headers.ContentType =new MediaTypeHeaderValue("aplicaion/json");
            }
        }*/
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
           // config.Formatters.Add(new TestJsonFormatter());
            // config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            //  config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = 
            //    Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(); عشان يخلي الحروف الاولى بالصغير
            //config.Formatters.Remove(config.Formatters.XmlFormatter); //عشان ما يرجع البيانات ك xml
            // config.Formatters.Remove(config.Formatters.JsonFormatter); //عشان ما يرجع البيانات ك json
            //config.Formatters.JsonFormatter.SupportedMediaTypes.Add
            //   (new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));// عشان اذا ما كتبت هذا الكود بيرجع على طول من المتصفح ك xmlولكن الان بيرجع دايما ك json  
        }
    }
}

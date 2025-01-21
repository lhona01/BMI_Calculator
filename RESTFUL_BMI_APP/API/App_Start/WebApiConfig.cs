﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RESTFUL_BMI
{
    public static class WebApiConfig
    {
public static void Register(HttpConfiguration config)
{
    // Enable CORS for the specific origin
    var cors = new EnableCorsAttribute("*", "*", "*");
    config.EnableCors(cors);

    // Web API configuration and services

    // Web API routes
    config.MapHttpAttributeRoutes();

    config.Routes.MapHttpRoute(
        name: "ActionApi",
        routeTemplate: "api/{controller}/{action}/{id}",
        defaults: new { id = RouteParameter.Optional }
    );

    config.Routes.MapHttpRoute(
        name: "DefaultApi",
        routeTemplate: "api/{controller}/{id}",
        defaults: new { id = RouteParameter.Optional }
    );

    GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
        new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));

    GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
        new QueryStringMapping("type", "xml", new MediaTypeHeaderValue("application/xml")));
}
    }
}

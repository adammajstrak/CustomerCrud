//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="MySuperCompany">
//     Copyright (c) MySuperCompany. All rights reserved.
// </copyright>
// <author>Adam MAJSTRAK</author>
//-----------------------------------------------------------------------

namespace CustomerOdataServiceSelfHost
{
    using System.Web.Http;
    using System.Web.OData.Builder;
    using System.Web.OData.Extensions;
    using CustomerDatabase.Model;
    using Owin;

    /// <summary>
    /// Self host startup configuration
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// This code configures Web API. The Startup class is specified as a type
        /// parameter in the WebApp.Start method.
        /// </summary>
        /// <param name="appBuilder">The application builder object</param>
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Address>("Addresses");
            builder.EntitySet<Customer>("Customers");
            config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());

            appBuilder.UseWebApi(config);
        }
    }
}

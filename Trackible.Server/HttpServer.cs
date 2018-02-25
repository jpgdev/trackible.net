using Microsoft.Owin.Hosting;
using System.Web.Http;
using Owin;

namespace Trackible.Server
{
  public class HttpServer
  {
    public HttpServer()
    {
    }

    private void Configure(IAppBuilder appBuilder)
    {
      // Configure Web API for self-host. 
      var config = new HttpConfiguration(); 
      
      config.MapHttpAttributeRoutes();
      
      config.Routes.MapHttpRoute( 
        name: "DefaultApi", 
        routeTemplate: "api/{controller}/{id}", 
        defaults: new { id = RouteParameter.Optional } 
      );

      appBuilder.UseWebApi(config); 
    }  


    public void Start(string endPoint)
    {
      WebApp.Start(endPoint, Configure);
    }
  }
}
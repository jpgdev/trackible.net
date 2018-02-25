using System;

namespace Trackible.Server
{
  public static class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var url = "http://localhost:5555";

      Console.WriteLine($"Starting server on '{url}'...");

//      Test();
      
      
      var server = new HttpServer();

      server.Start(url);

      Console.WriteLine($"Started server on '{url}'.");

      Console.ReadLine();
    }

//    public static void Test()
//    {
//      var type = Type.GetType(
//        "System.Configuration.ConfigurationManager, System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
//      var t =  (NameValueCollection) type.GetProperty("AppSettings").GetValue((object) null, new object[0]);
//      
//    }
  }
}

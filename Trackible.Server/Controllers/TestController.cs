using System.Web.Http;

namespace Trackible.Server.Controllers
{
  public class TestController : ApiController
  {
    // GET /api/Test
    public IHttpActionResult Get()
    {
      return Ok("Working");
    }
  }
}

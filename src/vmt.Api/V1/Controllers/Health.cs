using Microsoft.AspNetCore.Mvc;
using vmt.Api.Controllers;
using vmt.Business.Interfaces;

namespace vmt.Api.V1.Controllers
{
    [ApiVersion("1.0", Deprecated = true)]
    [Route("api/v{version:apiVersion}/health")]
    public class Health : MainController
    {
        public Health(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }

        [HttpGet]
        public ActionResult HealthTest()
        {
            return Ok("V1 - Ok");
        }
    }
}

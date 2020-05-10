using OXR.Trading.WebApi.Models;
using OXR.Trading.WebApi.Models.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OXR.Trading.WebApi.Controllers
{
    [Route("api/v1/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        #region Private Fields / Constructors
        private readonly IOptions<AppConfig> _appConfig;

        public TestController(IOptions<AppConfig> appConfig)
        {
            _appConfig = appConfig;
        }
        #endregion

        [HttpGet]
        [Route("healthCheck")]
        [ProducesResponseType(200, Type = typeof(ResponseTest))]
        public IActionResult Echo()
        {
            ResponseTest result = new ResponseTest()
            {
                Message = "The service is available!"
            };

            return Ok(result);
        }

        [HttpGet("version")]
        [ProducesResponseType(200, Type = typeof(ResponseTest))]
        public IActionResult Version()
        {
            ResponseTest result = new ResponseTest()
            {
                Message = string.Format($"API Version is { _appConfig.Value.ApiVersion }")
            };

            return Ok(result);
        }
    }
}
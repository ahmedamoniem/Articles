using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionsPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController(IOptions<Configs> ConfigsOptions) : ControllerBase
    {
        [HttpGet]
        public Configs Get()
        {
            var configs = ConfigsOptions.Value;
            return configs;
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace howToUseLocaLization.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> localizer;

        public LanguageController(IStringLocalizer<LanguageController> localizer)
        {
            this.localizer = localizer;
        }
        [HttpGet]
        public IActionResult Index()
        {

            return Ok(localizer["Welcome"].Value);
        }

    }
}
//"howToUseLocaLization.Resources.Controllers.Api.LanguageController"
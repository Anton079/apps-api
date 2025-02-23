using apps_api.Apps.Dtos;
using apps_api.Apps.Models;
using apps_api.Apps.Repository;
using Microsoft.AspNetCore.Mvc;

namespace apps_api.Apps.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AppController : ControllerBase
    {
        private IAppRepo _appRepo;

        public AppController(IAppRepo appRepo)
        {
            _appRepo = appRepo;
        }

        [HttpGet("allApps")]

        public async Task<ActionResult<List<App>>> GetAppAsync()
        {
            var app = await _appRepo.GetAppAsync();

            return Ok(app);
        }

        [HttpPost("add")]

        public async Task<ActionResult<AppResponse>> CreateAsync([FromBody]AppRequest appReq)
        {
            AppResponse appSaved = await _appRepo.CreateAppAsync(appReq);

            return Ok(appSaved);
        }
    }
}

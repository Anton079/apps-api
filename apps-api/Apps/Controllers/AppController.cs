using apps_api.App.Repository;
using Microsoft.AspNetCore.Mvc;

namespace apps_api.Apps.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AppController
    {
        private IAppRepo _appRepo;

        public AppController(IAppRepo appRepo)
        {
            _appRepo = appRepo;
        }

        [HttpGet]

        public async Task<ActionResult<List<App>>> GetAppAsync()
        {
            var app = await _appRepo.GetHashCode();

            return Ok(app);
        }
    }
}

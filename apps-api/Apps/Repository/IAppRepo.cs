using apps_api.Apps.Models;

namespace apps_api.Apps.Repository
{
    public interface IAppRepo
    {
        Task<List<App>> GetAppAsync();
    }
}

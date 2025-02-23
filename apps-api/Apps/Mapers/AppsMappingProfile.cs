using apps_api.Apps.Dtos;
using apps_api.Apps.Models;
using AutoMapper;

namespace apps_api.Apps.Mapers
{
    public class AppsMappingProfile:Profile
    {
        public AppsMappingProfile()
        {
            CreateMap<AppRequest, App>();
            CreateMap<App, AppResponse>();
        }
    }
}

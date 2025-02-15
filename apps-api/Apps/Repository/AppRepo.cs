using apps_api.Apps.Models;
using apps_api.Apps.Repository;
using apps_api.Data.Migrations;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace apps_api.Apps.Repository
{
    public class AppRepo : IAppRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public AppRepo(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task<List<App>> GetAppAsync()
        {
            return await _appDbContext.Apps.ToListAsync();
        }
    }
}

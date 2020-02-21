using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RacingGameDAL;
using RacingGameDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacingWebApi.Config
{
    public static class DALServices
    {
        public static void AddDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RacingDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("RacingGame")));
            services.AddScoped<DbContext, RacingDBContext>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}

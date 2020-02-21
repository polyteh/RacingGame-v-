using Microsoft.Extensions.DependencyInjection;
using RacingGameBLL.Interfaces;
using RacingGameBLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacingWebApi.Config
{
    public static class BLLServices
    {
        public static void AddBLLServices(this IServiceCollection services)
        {
            services.AddScoped<IManufacturerService, ManufacturerService>();
        }
    }
}

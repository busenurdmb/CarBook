using MediatR;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Services
{
    public static class ApplicationServiceRegistiration
    {

        public static void AddApplicationService(this IServiceCollection services)
        {
            //services.AddMediatR(Assembly.GetExecutingAssembly()); --->sürümden dolayı hata veriyor mediatR 12 de

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationServiceRegistiration).Assembly)); 
        }


        //public static void AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));

        //}
    }
}

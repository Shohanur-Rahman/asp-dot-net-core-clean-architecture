using App.Application.Services.Interfaces;
using App.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Application.IRepositories;
using App.Infrastructure.Repositories;

namespace App.Infrastructure
{
    public static class RegisterServices
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITestRepository, TestRepository>();
            return services;
        }
    }
}

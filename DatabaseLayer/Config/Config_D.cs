using DatabaseLayer.Context;
using DatabaseLayer.InterfaceD;
using DatabaseLayer.Operations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer.Config
{
    public static class Config_D
    {
        public static void Config(IConfiguration configuration,IServiceCollection services) {
            services.AddScoped<Interface_D_Todo, ProfileOperation>();
            services.AddScoped<Interface_D_Todolist, TodolistOperation>();
            services.AddDbContext<TodolistDbContext>(x => x.UseSqlServer(configuration.GetConnectionString("Con")));
        }
    }
}

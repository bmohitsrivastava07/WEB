using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer.Config;
using BusinessLayer.Logic;
using BusinessLayer.InterfaceB;

namespace BusinessLayer.Config
{
    public static class Config_B
    {
        public static void Config(IConfiguration configuration, IServiceCollection service)
        {
            service.AddScoped<Interface_B_Todo, ProfileLogic>();
            service.AddScoped<Interface_B_Todolist, TodolistLogic>();
            Config_D.Config(configuration, service);
        }
    }
}

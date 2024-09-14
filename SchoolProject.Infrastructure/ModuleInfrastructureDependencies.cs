﻿using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.InfrastructureBases;
using SchoolProject.Infrastructure.Repository;


namespace SchoolProject.Infrastructure
{
   public static class ModuleInfrastructureDependencies
    {

        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {

            services.AddTransient<IStudentRepository ,StudentRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;    
        } 
    }
}

﻿using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Core.Behavior;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection AddCoreDependecies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            services.AddAutoMapper(Assembly.GetExecutingAssembly());



            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));





            return services;
        }
    }
}
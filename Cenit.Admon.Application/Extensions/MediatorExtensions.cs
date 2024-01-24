using Cenit.Admon.Domain.Services.Interfaces;
using Cenit.Admon.Infraestructure.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Cenit.Admon.Application.Extensions
{
    public static class MediatorExtensions
    {

        public static IServiceCollection AddMediatorExtension( this IServiceCollection services)
        {            
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddTransient<ICustomerService, CustomerRepository>();
            return services;
        }
    }
}

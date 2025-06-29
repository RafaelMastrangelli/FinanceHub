using Microsoft.Extensions.DependencyInjection;
using FinanceHub.API.Repositories;
using FinanceHub.API.Services;

namespace FinanceHub.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddFinanceHubServices(this IServiceCollection services)
        {
            services.AddScoped<IInvestmentRepository, InvestmentRepository>();
            services.AddScoped<InvestmentService>();
            return services;
        }
    }
} 
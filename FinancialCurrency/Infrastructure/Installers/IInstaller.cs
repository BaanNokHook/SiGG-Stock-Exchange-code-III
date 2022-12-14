using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinancialCurrency.API.Infrastructure.Installers
{
    internal interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration configuration);
    }
}
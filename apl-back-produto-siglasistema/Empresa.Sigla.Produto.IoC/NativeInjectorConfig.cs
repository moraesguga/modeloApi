using Empresa.SiglaSistema.Produto.Domain;
using Empresa.SiglaSistema.Produto.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Empresa.SiglaSistema.Produto.IoC
{
    public static class NativeInjectorConfig
    {

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryCliente, RepositoryCliente>();
            services.AddScoped<Ilo>

        }
    }
}

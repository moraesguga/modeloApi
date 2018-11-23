using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Empresa.SiglaSistema.Domain.Interfaces;
using Empresa.SiglaSistema.Produto.Infra.Data.Mappings;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.IO;

namespace Empresa.SiglaSistema.Produto.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {

        protected readonly SqlConnection conn;

        public RepositoryBase()
        {

            if (FluentMapper.EntityMaps.IsEmpty)
            {
                FluentMapper.Initialize(config =>
                {
                    config.AddMap(new ClienteMap());                    
                    config.ForDommel();
                });
            }

            var configString = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            conn = new SqlConnection(configString.GetConnectionString("connectionString"));
        }

        public void Dispose()
        {
            conn.Close();
            GC.SuppressFinalize(this);
        }
    }
}

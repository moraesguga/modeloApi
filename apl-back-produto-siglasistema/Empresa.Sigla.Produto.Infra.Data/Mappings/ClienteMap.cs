using Empresa.SiglaSistema.Produto.Domain.Entities;
using Dapper.FluentMap.Dommel.Mapping;


namespace Empresa.SiglaSistema.Produto.Infra.Data.Mappings
{
    public class ClienteMap : DommelEntityMap<Cliente>
    {

        public ClienteMap()
        {
            Map(x => x.Cpf).ToColumn("NUMERODOCUMENTO");
            Map(x => x.Nome).ToColumn("NOME");

        }
    }
}

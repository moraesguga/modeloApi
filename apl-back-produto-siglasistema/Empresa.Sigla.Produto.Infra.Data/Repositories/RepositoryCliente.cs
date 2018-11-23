using Empresa.SiglaSistema.Produto.Domain;
using Empresa.SiglaSistema.Produto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa.SiglaSistema.Produto.Infra.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public void AddCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetList(int cpf)
        {
            throw new NotImplementedException();
        }
    }
}

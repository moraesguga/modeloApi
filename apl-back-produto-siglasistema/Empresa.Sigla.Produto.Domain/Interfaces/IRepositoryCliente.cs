using Empresa.SiglaSistema.Produto.Domain.Entities;
using System.Collections.Generic;

namespace Empresa.SiglaSistema.Produto.Domain
{
    public interface IRepositoryCliente
    {
        List<Cliente> GetList(int cpf);
        void AddCliente(Cliente cliente);


    }
}
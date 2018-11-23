using Empresa.SiglaSistema.Produto.Domain.Entities;
using System.Collections.Generic;

namespace Empresa.SiglaSistema.Produto.Service
{
    public interface IClienteService
    {

        List<Cliente> GetCliente(int numeroCpf);
        void ClienteCadastrar(Cliente cliente);
    }
}
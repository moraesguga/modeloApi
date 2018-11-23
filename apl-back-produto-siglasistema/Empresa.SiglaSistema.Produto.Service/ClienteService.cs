using Empresa.SiglaSistema.Produto.Domain;
using Empresa.SiglaSistema.Produto.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Empresa.SiglaSistema.Produto.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IRepositoryCliente _repositoryCliente;

        public ClienteService(IRepositoryCliente repositoryCliente)
        {
            _repositoryCliente = repositoryCliente;
        }

        public List<Cliente> GetCliente(int numeroCpf)
        {

            try
            {
               return _repositoryCliente.GetList(numeroCpf);
            }
            catch (Exception)
            {
                throw;
            }          

        }

        public void ClienteCadastrar(Cliente cliente)
        {
            try
            {
                _repositoryCliente.AddCliente(cliente);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

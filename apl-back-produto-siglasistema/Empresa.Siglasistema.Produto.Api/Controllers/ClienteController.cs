using System;
using Empresa.SiglaSistema.Produto.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Empresa.SiglaSistema.Produto.Api.Controllers
{
    [Route("apl-back-produto-siglasistema/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(IClienteService clienteService, ILogger<ClienteController> logger)
        {
            _clienteService = clienteService;
            _logger = logger;
        }

        public IActionResult GetCliente(int cpf)
        {
            try
            {
                var cliente = _clienteService.GetCliente(cpf);
                return Ok(cliente);
               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500);
            }

            
           
        }
            

    }
}
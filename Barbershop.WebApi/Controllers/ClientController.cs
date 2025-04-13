using Barbershop.Services.Services.Clients.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Barbershop.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly ILogger<ClientController> _logger;
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService, ILogger<ClientController> logger)
    {
        _logger = logger;
        _clientService = clientService;
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetClientById([FromQuery] int id)
    {
        _logger.LogInformation("Fetching client data. {id}", id);

        var client = await _clientService.GetClientByIdAsync(id);

        return Ok(client);
    }
}
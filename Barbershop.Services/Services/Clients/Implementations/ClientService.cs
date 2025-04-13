using Barbershop.Services.Services.Clients.Interfaces;
using Barbershop.Services.Services.Clients.ViewModels;

namespace Barbershop.Services.Services.Clients.Implementations;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<ClientViewModel> GetClientByIdAsync(int id)
    {
        try
        {
            var client = await _clientRepository.GetClientByIdAsync(id);

            return new ClientViewModel()
            {
                Id = client.Id,
                CreatedAt = client.CreatedAt,
                DateOfBirth = client.DateOfBirth,
                Email = client.Email,
                Name = client.Name,
                PhoneNumber = client.PhoneNumber
            };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<List<ClientViewModel>> GetAllClientsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task AddClientAsync(AddClientViewModel client)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateClientAsync(UpdateClientViewModel client)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteClientAsync(int id)
    {
        throw new NotImplementedException();
    }
}
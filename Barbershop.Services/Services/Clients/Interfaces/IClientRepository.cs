using Barbershop.Entities.Entities;

namespace Barbershop.Services.Services.Clients.Interfaces;

public interface IClientRepository
{
    Task<Client> GetClientByIdAsync(int id);
    Task<List<Client>> GetAllClientsAsync();
    Task AddClientAsync(Client client);
    Task UpdateClientAsync(Client client);
    Task DeleteClientAsync(int id);
}
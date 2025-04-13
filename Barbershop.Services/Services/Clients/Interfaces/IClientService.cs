using Barbershop.Entities.Entities;
using Barbershop.Services.Services.Clients.ViewModels;

namespace Barbershop.Services.Services.Clients.Interfaces;

public interface IClientService
{
    Task<ClientViewModel> GetClientByIdAsync(int id);
    Task<List<ClientViewModel>> GetAllClientsAsync();
    Task AddClientAsync(AddClientViewModel client);
    Task UpdateClientAsync(UpdateClientViewModel client);
    Task DeleteClientAsync(int id);
}
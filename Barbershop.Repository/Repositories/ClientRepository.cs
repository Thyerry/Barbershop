using Barbershop.Entities.Entities;
using Barbershop.Services.Services.Clients.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Barbershop.Repository.Repositories;

public class ClientRepository : IClientRepository
{
    private readonly string? _connectionString;
    public ClientRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    public async Task<Client> GetClientByIdAsync(int id)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        await connection.OpenAsync();

        return await connection.QuerySingleAsync<Client>($"SELECT * FROM clients WHERE Id = @Id;", new { Id = id });
    }

    public async Task<List<Client>> GetAllClientsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task AddClientAsync(Client client)
    {
        await using var connection = new NpgsqlConnection(_connectionString);
        await connection.OpenAsync();
        
        await connection.ExecuteAsync(
            """
            INSERT INTO clients 
                (Name, DateOfBirth, Email, PhoneNumber) 
            VALUES 
                (@Name, @DateOfBirth, @Email, @PhoneNumber);"
            """, client);
    }

    public async Task UpdateClientAsync(Client client)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteClientAsync(int id)
    {
        throw new NotImplementedException();
    }
}
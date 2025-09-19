using Grocery.Core.Models;
using Grocery.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grocery.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        // Simuleer een database met een interne lijst
        private readonly List<Client> _clients = new List<Client>
        {
            new Client(1, "John Doe", "john@example.com", "password123"),
            new Client(2, "Jane Smith", "jane@example.com", "password456"),
            new Client(3, "Bob Johnson", "bob@example.com", "password789")
        };

        public Client? Get(string email)
        {
            // Zoek client op email
            return _clients.FirstOrDefault(c => c.EmailAddress.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public Client? Get(int id)
        {
            // Zoek client op id
            return _clients.FirstOrDefault(c => c.Id == id);
        }

        public List<Client> GetAll()
        {
            // Retourneer alle clients
            return _clients.ToList();
        }
    }

    public interface IClientRepository
    {
        Client? Get(string email);
        Client? Get(int id);
        List<Client> GetAll();
    }
}

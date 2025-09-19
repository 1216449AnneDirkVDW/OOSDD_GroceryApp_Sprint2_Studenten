using Grocery.Core.Interfaces.Services;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;
using Grocery.Infrastructure.Repositories;

namespace Grocery.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly IClientRepository _clientRepository;

        public AuthService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client? Login(string email, string password)
        {
            // Haal client op via email
            var client = _clientRepository.Get(email);
            if (client == null) return null;

            // Controleer het wachtwoord via de methode in Client
            return client.VerifyPassword(password) ? client : null;
        }
    }

    public interface IAuthService
    {
        public Client? Login(string email, string password);
    }
}

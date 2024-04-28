using HotelManagementV2.src.HotelManagementSystem.Domain.Entities;
using HotelManagementV2.src.HotelManagementSystem.Domain.Services.Contracts;

namespace HotelManagementV2.src.HotelManagementSystem.Domain.Implementations
{
    public class AdditionalFunctionalityDecorator : IClientDecorator
    {
        private readonly Client _client;

        public AdditionalFunctionalityDecorator(Client client)
        {
            _client = client;
        }

        public void DecorateClient(Client client)
        {
            // Implémenter la logique pour ajouter des fonctionnalités supplémentaires au client
        }
    }
}

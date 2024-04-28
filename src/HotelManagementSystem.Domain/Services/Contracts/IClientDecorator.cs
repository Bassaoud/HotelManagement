using HotelManagementV2.src.HotelManagementSystem.Domain.Entities;

namespace HotelManagementV2.src.HotelManagementSystem.Domain.Services.Contracts
{
    public interface IClientDecorator
    {
        void DecorateClient(Client client);
    }
}

using HotelManagementV2.src.HotelManagementSystem.Domain.Entities;

namespace HotelManagementV2.src.HotelManagementSystem.Domain.Entities.Contracts
{
    public interface IClientRepository
    {
        Client GetById(Guid id);
        IEnumerable<Client> GetAll();
        void Add(Client client);
        void Update(Client client);
        void Delete(Client client);
    }
}

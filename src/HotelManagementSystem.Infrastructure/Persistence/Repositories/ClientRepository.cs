using HotelManagementV2.src.HotelManagementSystem.Domain.Entities;
using HotelManagementV2.src.HotelManagementSystem.Domain.Entities.Contracts;

namespace HotelManagementV2.src.HotelManagementSystem.Infrastructure.Persistence.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly HotelDbContext _context;

        public ClientRepository(HotelDbContext context)
        {
            _context = context;
        }

        public Client GetById(Guid id)
        {
            return _context.Clients.FirstOrDefault(c => c.ClientId == id);
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public void Add(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void Update(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }

        public void Delete(Client client)
        {
            _context.Clients.Remove(client);
            _context.SaveChanges();
        }
    }
}

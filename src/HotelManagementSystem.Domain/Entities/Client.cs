namespace HotelManagementV2.src.HotelManagementSystem.Domain.Entities
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientPhone { get; set; }
        public string ClientPassword { get; set; }
    }
}

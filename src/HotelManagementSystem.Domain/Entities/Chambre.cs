namespace HotelManagementV2.src.HotelManagementSystem.Domain.Entities
{
    public class Chambre
    {

        public int ChambreId { get; set; }
        public string ChambreType { get; set; }
        public int ChambreCapacity { get; set; }
        public decimal ChambreRate { get; set; }
        public string ChambreStatus { get; set; }
        public double ChambrePrice { get; set; }
        public bool ChambreIsClean { get; set; }
        public List<ChambreReservation> RoomReservations { get; set; } = new List<ChambreReservation>();
    }
}

namespace HotelManagementV2.src.HotelManagementSystem.Domain.Entities
{
    public class ChambreReservation
    {
        public int ChambreReservationId { get; set; }
        public int ChambreReservationRoomId { get; set; }
        public Chambre ChambreReservationRoom { get; set; }
        public int ChambreReservationReservationId { get; set; }
        public Reservation ReservationChambre { get; set; }
    }
}

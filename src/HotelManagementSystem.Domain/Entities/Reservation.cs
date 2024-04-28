namespace HotelManagementV2.src.HotelManagementSystem.Domain.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int ReservationClientId { get; set; }
        public Client ReservationClient { get; set; }
        public DateTime ReservationCheckInDate { get; set; }
        public DateTime ReservationCheckOutDate { get; set; }
        public bool ReservationIsCheckedIn { get; set; }
        public bool ReservationIsCheckedOut { get; set; }
        public List<ChambreReservation> ChambreReservations { get; set; } = new List<ChambreReservation>();
        public decimal ReservationTotalPrice { get; set; }
        public bool ReservationIsCancelled { get; set; }
        public int ReservationNumberOfGuests { get; set; }
    }
}

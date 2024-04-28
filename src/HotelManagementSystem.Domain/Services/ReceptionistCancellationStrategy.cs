using HotelManagementV2.src.HotelManagementSystem.Domain.Entities;
using HotelManagementV2.src.HotelManagementSystem.Domain.Services.Contracts;

namespace HotelManagementV2.src.HotelManagementSystem.Domain.Implementations
{
    public class ReceptionistCancellationStrategy : IReservationCancellationStrategy
    {
        public void CancelReservation(Reservation reservation)
        {
            // Logique d'annulation de réservation pour le réceptionniste
            // Par exemple : possibilité de remboursement différent pour les annulations tardives
        }
    }
}

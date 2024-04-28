using HotelManagementV2.src.HotelManagementSystem.Domain.Entities;
using HotelManagementV2.src.HotelManagementSystem.Domain.Services.Contracts;

namespace HotelManagementV2.src.HotelManagementSystem.Application.Services
{
    public class ReservationService
    {
        private readonly IReservationCancellationStrategy _cancellationStrategy;

        public ReservationService(IReservationCancellationStrategy cancellationStrategy)
        {
            _cancellationStrategy = cancellationStrategy;
        }

        public void AnnulerReservation(Reservation reservation)
        {
            // Utilisation de la stratégie d'annulation de réservation appropriée
            _cancellationStrategy.CancelReservation(reservation);
        }
    }
}

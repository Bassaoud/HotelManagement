using HotelManagementV2.src.HotelManagementSystem.Domain.Entities;
using HotelManagementV2.src.HotelManagementSystem.Domain.Services.Contracts;

namespace HotelManagementV2.src.HotelManagementSystem.Domain.Implementations
{
    public class ClientCancellationStrategy : IReservationCancellationStrategy
    {
        public void CancelReservation(Reservation reservation)
        {
            // Logique d'annulation de réservation pour le client
            // Par exemple : rembourser le client selon les règles spécifiées
            // Ajoutez ici la logique nécessaire pour annuler la réservation pour un client
        }


    }
}

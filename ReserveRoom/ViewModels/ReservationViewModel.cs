using ReserveRoom.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReserveRoom.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomID => _reservation.RoomID?.ToString();
        public string UserName => _reservation.UserName;
        public string StartDate => _reservation.StartTime.ToShortDateString();
        public string EndDate => _reservation.EndTime.ToShortDateString();

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}

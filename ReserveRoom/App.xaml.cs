using ReserveRoom.Exceptions;
using ReserveRoom.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ReserveRoom
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Mayer Doa");

            try
            {
                hotel.MakeReservation(new Reservation(
                new RoomID(1, 11),
                "Saiful Islam",
                new DateTime(2023, 1, 1),
                new DateTime(2023, 1, 5)));

                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 11),
                    "Saiful Alam",
                    new DateTime(2023, 1, 4),
                    new DateTime(2023, 1, 10)));
            }
            catch (ReservationConflictException ex)
            {

            }
            

            IEnumerable<Reservation> reservations = hotel.GetAllReservations();

            base.OnStartup(e);
        }
    }
}

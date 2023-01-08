using System;
using System.Collections.Generic;
using System.Text;

namespace ReserveRoom.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            //CurrentViewModel = new MakeReservationViewModel();
            CurrentViewModel = new ReservationListingViewModel();
        }
    }
}

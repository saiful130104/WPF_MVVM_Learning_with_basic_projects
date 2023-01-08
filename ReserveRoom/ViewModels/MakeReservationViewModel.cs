using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ReserveRoom.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {
        #region properties
        private string _username;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get
            {
                return _floorNumber;
            }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get
            {
                return _roomNumber;
            }
            set
            {
                _roomNumber = value;
                OnPropertyChanged(nameof(RoomNumber));
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }
        #endregion

        #region commands
        private ICommand _submitCommand;
        public ICommand SubmitCommand { get; }
        
        private ICommand _cancelCommand;
        public ICommand CancelCommand { get; }
        #endregion

        #region constructor
        public MakeReservationViewModel()
        {

        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation.Model
{
    public class Reservation
    {
        private List<Room> _room;
        private User _user;
        private DateTime _startDate;
        private DateTime _endDate;

        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        public User User
        {
            set
            {
                _user = value;
                OnPropertyChanged("User");
            }
            get
            {
                return _user;
            }
        }

        public DateTime EndDate
        {
            set
            {
                _endDate = value;
                OnPropertyChanged("EndDate");
            }
            get
            {
                return _endDate;
            }
        }

        public List<Room> Rooms
        {
            set
            {
                _room = value;
                OnPropertyChanged("Rooms");
            }
            get
            {
                return _room;
            }
        }

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}

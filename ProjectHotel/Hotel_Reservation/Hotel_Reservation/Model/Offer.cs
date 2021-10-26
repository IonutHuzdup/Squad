using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation.Model
{
    public class Offer : INotifyPropertyChanged
    {
        #region Declarations
        private Room _offerRoom;
        private string _title;
        private DateTime _startPeriod;
        private DateTime _endPeriod;
        private int _no_Nights;
        private double _price;
        #endregion

        #region Getters and Setters
        public Room OfferRoom
        {
            get
            {
                return _offerRoom;
            }
            set
            {
                _offerRoom = value;
                OnPropertyChanged("OfferRoom");
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }
        public DateTime StartPeriod
        {
            get
            {
                return _startPeriod;
            }
            set
            {
                _startPeriod = value;
                OnPropertyChanged("StartPeriod");
            }
        }
        public DateTime EndPeriod
        {
            get
            {
                return _endPeriod;
            }
            set
            {
                _endPeriod = value;
                OnPropertyChanged("StartPeriod");
            }
        }
        public int No_Nights
        {
            get
            {
                return _no_Nights;
            }
            set
            {
                _no_Nights = value;
                OnPropertyChanged("No_Nights");
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}

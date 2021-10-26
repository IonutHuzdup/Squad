using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation.Model
{
    public class Room : INotifyPropertyChanged
    {
        public Room()
        {
            Facilities = new List<Facility>();
            Images = new List<Tuple<string, string>>();
            ExtrasAvailable = new List<Extras>();
        }
        #region Declarations
        private string _name;
        public bool isDeleted { get; set; }
        private int _capacity;
        private List<Facility> _facilities;
        public string FacilitiesConcat { set; get; }
        private List<Extras> _extrasAvailable; //The extra options available and selected
        public int Quantity { get; set; }
        private double _standPrice;

        public List<Tuple<string, string>> Images { get; set; }
        public int ID { get; set; }
        #endregion

        #region Getters and Setters
        public int Capacity
        {
            set
            {
                _capacity = value;
                OnPropertyChanged("Capacity");
            }
            get
            {
                return _capacity;
            }
        }
        public string  Name
        {
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
            get
            {
                return _name;
            }
        }

        public List<Facility> Facilities
        {
            set
            {
                _facilities = value;
                OnPropertyChanged("Facilities");
            }
            get
            {
                return _facilities;
            }
        }

        public List<Extras> ExtrasAvailable
        {
            set
            {
                _extrasAvailable = value;
                OnPropertyChanged("ExtrasAvailable");
            }
            get
            {
                return _extrasAvailable;
            }
        }

        public double StandPrice
        {
            set
            {
                _standPrice = value;
                OnPropertyChanged("StandPrice");
            }
            get
            {
                return _standPrice;
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
    public class Facility : INotifyPropertyChanged
    {
        #region Declarations
        private string _name;
        private string _description;
        private bool _isAvailable;
        #endregion

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
    public class Extras : INotifyPropertyChanged
    {
        #region Declarations
        private string _name;
        private string _description;
        private bool _isAvailable;
        private double _price;
        #endregion

        #region Getters and Setters
        public string Name
        {
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
            get
            {
                return _name;
            }
        }

        public string Description
        {
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
            get
            {
                return _description;
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

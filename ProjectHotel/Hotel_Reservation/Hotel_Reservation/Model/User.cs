using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation.Model
{
    public class User : INotifyPropertyChanged
    {
        public User()
        {
            _contact = new Contact_Information();
        }
        #region Declarations
        private string _username;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _type; //Employee, Administrator, Client
        private string _paymentInfo;
        private Contact_Information _contact;
        public int ID { get; set; }
        #endregion

        #region Getters and Setters
        public string Username
        {
            set
            {
                _username = value;
                OnPropertyChanged("Username");
            }
            get
            {
                return _username;
            }
        }
        public string Password
        {
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
            get
            {
                return _password;
            }
        }
        public string FirstName
        {
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
            get
            {
                return _lastName;
            }
        }
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                OnPropertyChanged("Type");
            }
        }
        public string PaymentInfo
        {
            set
            {
                _paymentInfo = value;
                OnPropertyChanged("PaymentInfo");
            }
            get
            {
                return _paymentInfo;
            }
        }
        public Contact_Information Contact
        {
            set
            {
                _contact = value;
                OnPropertyChanged("Contact");
            }
            get
            {
                return _contact;
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

    public class Contact_Information : INotifyPropertyChanged
    {
        #region Declarations
        private string _email;
        private string _fax;
        private string _mobile;
        private int _age;
        private string _adress;
        #endregion

        #region Getters and Setters
        public string Email
        {
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
            get
            {
                return _email;
            }
        }
        public string Fax
        {
            set
            {
                _fax = value;
                OnPropertyChanged("Fax");
            }
            get
            {
                return _fax;
            }
        }
        public string Mobile
        {
            set
            {
                _mobile = value;
                OnPropertyChanged("Mobile");
            }
            get
            {
                return _mobile;
            }
        }
        public int Age
        {
            set
            {
                _age = value;
                OnPropertyChanged("Home");
            }
            get
            {
                return _age;
            }
        }
        public string Adress
        {
            set
            {
                _adress = value;
                OnPropertyChanged("Adress");
            }
            get
            {
                return _adress;
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

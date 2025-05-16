using BubblyChat.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubblyChat.MVVM.ViewModel
{
    public class UpdateProfileVM : ViewModelBase
    {
        private string _username;

        private string _pnumber;

        private DateTime _birthdate = DateTime.Now;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string PNumber
        {
            get { return _pnumber; }
            set
            {
                _pnumber = value;
                OnPropertyChanged(nameof(PNumber));
            }
        }
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set
            {
                _birthdate = value;
                OnPropertyChanged(nameof(Birthdate));
            }
        }




    }
}

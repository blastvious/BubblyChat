using BubblyChat.Core;
using BubblyChat.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BubblyChat.Service;

namespace BubblyChat.MVVM.ViewModel
{
    public class ChattingVM : ViewModelBase
    {

        public ObservableCollection<MessageModel> _Messages { get; set; }
        public ObservableCollection<ContactModel> _Contacts { get; set; }
        private Users _currentUser;
        private FirebaseStorageService _storageService;

        /* Commands */
        public RelayCommand SendCommand { get; set; }
        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                _selectedContact = value;
                OnPropertyChanged();
                //    Messages = _selectedContact?.Messages ?? new ObservableCollection<MessageModel>();
                //    OnPropertyChanged(nameof(Messages));
                //
            }
        }
        public Users CurrentUser
        {
            get { return _currentUser; }
            set
            {
                _currentUser = value;
                OnPropertyChanged();
            }
        }
        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();

            }
        }

        public ChattingVM()
        {
            CurrentUser = CurrentUserService.CurrentUser;
            _storageService = new FirebaseStorageService();

            SendCommand = new RelayCommand(o =>
            {
                _Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false,


                });
                Message = "";

            });
            _Messages = new ObservableCollection<MessageModel>();
            _Contacts = new ObservableCollection<ContactModel>();

            _Messages.Add(new MessageModel
            {
                Username = "Tuan",
                UsernameColor = "#409aff",
                ImageSource = "/Images/1.jpg",
                Message = "Hello",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++)
            {
                _Messages.Add(new MessageModel
                {
                    Username = "Nghia",
                    UsernameColor = "#409aff",
                    ImageSource = "/Images/1.jpg",
                    Message = "Hello",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++)
            {
                _Messages.Add(new MessageModel
                {
                    Username = "An",
                    UsernameColor = "#409aff",
                    ImageSource = "/Images/1.jpg",
                    Message = "Hello",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }
            _Messages.Add(new MessageModel
            {
                Username = "An",
                UsernameColor = "#409aff",
                ImageSource = "/Images/1.jpg",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            for (int i = 0; i < 5; i++)         
            {
                _Contacts.Add(new ContactModel
                {
                    Username = $"Tuan{i}",
                    ImageSource = "/Images/1.jpg",
                    Messages = _Messages
                });
            }

        }
        //To DO : Init info currebt user and load messages from Firebase
        public async Task InitAysnc()
        {
            CurrentUser = CurrentUserService.CurrentUser;
            if(_currentUser == null)
            {
                return;
            }
            


        }

    }
}

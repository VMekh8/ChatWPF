using ChatWPF.Core;
using ChatWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPF.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages{ get; set; }
        public ObservableCollection<ContactModel> Contacts{ get; set; }


        private ContactModel _selectedContact;

        public  ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set { _selectedContact = value;
                OnPropertyChange();
            }
        }


        public RelayCommand SendCommand { get; set; }

        private string _message;

        public string Message {
            get { return _message; }
            set { _message = value; OnPropertyChange(); }
        }


        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });
                Message = "";
            });


            Messages.Add(new MessageModel
            {
                Username = "allison",
                UsernameColor = "#409aff",
                ImageSource = "../pictures/avatar1.jpg",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });


          

            Contacts.Add(new ContactModel
            {
                Username = "allison",
                ImageSource = "../pictures/avatar1.jpg",
                Messages = Messages

            });


        }
    }
}

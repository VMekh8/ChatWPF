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


        public ContactModel SelectedContact { get; set; }
            
        

        private string _message;

        public string Message {
            get { return _message; }
            set { _message = value; OnPropertyChange(); }
        }


        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();


            Messages.Add(new MessageModel
            {
                Username = "allison",
                UsernameColor = "#409aff",
                ImageSource = "../pictures/avatar1.jpg",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true
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

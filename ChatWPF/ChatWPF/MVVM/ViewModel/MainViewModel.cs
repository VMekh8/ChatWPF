using ChatWPF.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPF.MVVM.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages{ get; set; }
        public ObservableCollection<ContactModel> Contacts{ get; set; }


        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();


            Messages.Add(new MessageModel
            {
                Username = "allison",
                UsernameColor = "#409aff",
                imageSource = "",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true
            });

            Contacts.Add(new ContactModel
            {
                Username = "allison",
                imageSource = "",
                Messages = Messages

            });
        }
    }
}

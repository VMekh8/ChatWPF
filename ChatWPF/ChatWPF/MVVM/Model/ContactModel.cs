using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPF.MVVM.Model
{
    class ContactModel
    {

        public string Username { get; set; }
        public string ImageSource { get; set; }
        public ObserbableCollection<MessageModel> MyProperty { get; set; }
    }
}

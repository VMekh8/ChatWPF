using ChatWPF.Core;
using ChatWPF.MVVM.Model;
using ChatWPF.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPF.MVVM.ViewModel
{
    class LoginViewModel
    {
        public ObservableCollection<UserModel> Users { get; set; };
        private Server _server;
        public string Username { get; set; }
        public RelayCommand ConnectToServerCommand { get; set; }

        public LoginViewModel()
        {
            Users = new ObservableCollection<UserModel>();
            _server = new Server();
            _server.ConnectedEvent += UserConnected;
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer(Username), o => !string.IsNullOrEmpty(Username));
            Console.WriteLine(Username);
            
        }

        private void UserConnected()
        {
            var user = new UserModel
            {
                Username = _server.PacketReader.ReadMessage(),
                UID = _server.PacketReader.ReadMessage()
            };
        }
    }
}

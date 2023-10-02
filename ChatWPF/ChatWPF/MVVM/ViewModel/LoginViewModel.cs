using ChatWPF.Core;
using ChatWPF.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWPF.MVVM.ViewModel
{
    class LoginViewModel
    {
        private Server _server;
        public string Username { get; set; }
        public RelayCommand ConnectToServerCommand { get; set; }

        public LoginViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new RelayCommand(o => _server.ConnectToServer(Username), o => !string.IsNullOrEmpty(Username));
            Console.WriteLine(Username);
            
        }
    }
}

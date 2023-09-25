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

        public RelayCommand ConnectToServerCommand { get; set; }

        public LoginViewModel()
        {
            _server = new Server();
            ConnectToServerCommand = new RelayCommand(o =>
            {
                _server.ConnectToServer();
            });
        }
    }
}

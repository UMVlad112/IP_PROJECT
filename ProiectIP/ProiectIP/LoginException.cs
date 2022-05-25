﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    /// <summary>
    /// Clasa de exceptie utilizata la log-in. Se verifica daca username-ul si parola sunt completate si daca numele de utilizator este unic.
    /// </summary>
    class LoginException :Exception
    {
        private string _message;
        public LoginException(string message) : base(message)
        {
            this._message = message;
        }

        public string GetMessage
        {
            get
            {
                return this._message;
            }
        }
    }
}

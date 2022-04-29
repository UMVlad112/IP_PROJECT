﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    class LoginException:Exception
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
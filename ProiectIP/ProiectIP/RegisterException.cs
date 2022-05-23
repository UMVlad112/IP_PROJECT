using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    /// <summary>
    /// Clasa de exceptie utilizata la inregistrarea unui nou utilizator
    /// </summary>
    class RegisterException:Exception
    {
        private string _message;
        public RegisterException(string message): base(message)
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

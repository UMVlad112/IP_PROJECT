/**************************************************************************
 *                                                                        *
 *  File:        LoginException.cs                                        *
 *  Copyright:   (c) 2022, Ilie Florentin                                 *
 *  Description: Clasa de exceptie utilizata la log-in.                   *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using System;
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

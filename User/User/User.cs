/**************************************************************************
 *                                                                        *
 *  File:        User.cs                                                  *
 *  Copyright:   (c) 2022, Ilie Florentin                                 *
 *  Description: Clasa care stocheaza informatiile unui utilizator.       *
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
    /// Clasa care stocheaza informatiile unui utilizator 
    /// </summary>
    public class User
    {


        private string _username;
        private string _hashPassword;
        private bool _isAdmin;

        /// <summary>
        /// Getter pentru parametrul username al unui utilizator 
        /// </summary>
        public string GetUsername
        {
            get
            {
                return this._username;
            }
        }

        /// <summary>
        /// Getter pentru parola hashuita a unui utilizator 
        /// </summary>
        public string GetHashPassword
        {
            get
            {
                return this._hashPassword;
            }
        }
        /// <summary>
        /// Getter pentru a verifica daca utilizatorul este sau nu admin
        /// </summary>
        public bool GetIsAdmin
        {
            get
            {
                return this._isAdmin;
            }
        }
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="username"></param>
        /// Usernameul introdus
        /// <param name="hashPassword"></param>
        /// Hash-ul parolei introduse
        /// <param name="isAdmin"></param>
        /// Nivelul de acces al utilizatorului
        public User(string username, string hashPassword, bool isAdmin)
        {
            this._username = username;
            this._hashPassword = hashPassword;
            this._isAdmin = isAdmin;
        }
    }

}

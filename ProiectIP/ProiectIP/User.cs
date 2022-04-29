using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    public class User
    {
        private string _username;
        private string _hashPassword;
        private bool _isAdmin;
        
        public string GetUsername
        {
            get
            {
                return this._username;
            }
        }

        public string GetHashPassword
        {
            get
            {
                return this._hashPassword;
            }
        }
        public bool GetIsAdmin
        {
            get
            {
                return this._isAdmin;
            }
        }

        public User(string username,string hashPassword,bool isAdmin)
        {
            this._username = username;
            this._hashPassword = hashPassword;
            this._isAdmin = isAdmin;
        }
    }

}

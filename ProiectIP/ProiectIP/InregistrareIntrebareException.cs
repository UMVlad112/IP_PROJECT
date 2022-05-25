/**************************************************************************
 *                                                                        *
 *  File:        InregistrareIntrebareException.cs                        *
 *  Copyright:   (c) 2022, Cruceanu Bianca Miruna                         *
 *  Description: Clasa de exceptie utilizata la crearea unei intrebari    *
 *                de catre un user cu drepturi de admin.                  *
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
    /// Clasa de exceptie utilizata la crearea unei intrebari de catre un user cu drepturi de admin. Exceptia este aruncata atunci cand lipseste intrebarea sau unul dintre raspunsuri.
    /// </summary>
    class InregistrareIntrebareException:Exception
    {
        private string _message;
        public InregistrareIntrebareException(string message):base(message)
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

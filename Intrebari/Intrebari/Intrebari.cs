/**************************************************************************
 *                                                                        *
 *  File:        Intrebari.cs                                             *
 *  Copyright:   (c) 2022, Ionita Bogdan-Marian                           *
 *  Description: Clasa care stocheaza toate informatiile necesare         *
 *               crearii unei intrebari.                                  *
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
    /// Clasa care stocheaza toate informatiile necesare crearii unei intrebari
    /// </summary>
    public class Intrebare
    {
        private string _intrebare;
        private List<string> _raspunsuri;
        private int _indexRaspunsCorect;
        /// <summary>
        /// Getter pentru a obtine intrebarea propriu zisa.
        /// </summary>
        public string GetIntrebare
        {
            get
            {
                return this._intrebare;
            }
        }
        /// <summary>
        /// Getter pentru a obtine lista de raspunsuri pentru intrebarea curenta
        /// </summary>
        public List<string> GetRaspunsuri
        {
            get
            {
                return this._raspunsuri;
            }
        }
        /// <summary>
        /// Getter pentru a obtine raspunsul corect la intrebare
        /// </summary>
        public string GetRaspunsCorect
        {
            get
            {
                return this._raspunsuri[this._indexRaspunsCorect];
            }
        }
        /// <summary>
        /// Getter pentru a obtine indexul intrebarii corecte.
        /// </summary>
        public int GetIndexRaspunsCorect
        {
            get
            {
                return this._indexRaspunsCorect;
            }
        }
        /// <summary>
        /// Constructor pentru clasa Intrebare
        /// </summary>
        /// <param name="intrebare">
        /// String-ul cu intrebarea
        /// </param>
        /// <param name="raspuns1">
        /// Primul raspuns la intrebare
        /// </param>
        /// <param name="raspuns2">
        /// Al doilea raspuns la intrebare
        /// </param>
        /// <param name="raspuns3">
        /// Al treilea raspuns la intrebare
        /// </param>
        /// <param name="raspuns4">
        /// Ultimul raspuns la intrebare</param>
        /// <param name="indexRaspunsCorect">
        /// Indexul raspunsului corect (intre 0 si 3)
        /// </param>
        public Intrebare(string intrebare, string raspuns1, string raspuns2, string raspuns3, string raspuns4, int indexRaspunsCorect)
        {
            this._intrebare = intrebare;
            this._indexRaspunsCorect = indexRaspunsCorect;
            this._raspunsuri = new List<string>();
            this._raspunsuri.Add(raspuns1);
            this._raspunsuri.Add(raspuns2);
            this._raspunsuri.Add(raspuns3);
            this._raspunsuri.Add(raspuns4);
        }
    }
}

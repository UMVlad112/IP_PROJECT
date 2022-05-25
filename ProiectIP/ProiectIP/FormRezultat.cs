/**************************************************************************
 *                                                                        *
 *  File:        FormRezultat.cs                                          *
 *  Copyright:   (c) 2022, Ungureanu Mihai-Vladut                         *
 *  Description: Clasa de tip Windows Forms, folosita pentru a            *
 *               realiza interfata prin care utilizatorul vizualizeaza    *
 *               rezultatul obtinut la chestionar.                        *
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    /// <summary>
    /// Form-ul care se deschide atunci cand user-ul termina cele 10 intrebari, sau timpul alocat chestionarului expira.
    /// </summary>
    public partial class FormRezultat : Form
    {
        private Form _formLogin;
        private User _user;
        private int _punctaj;
        /// <summary>
        /// Constructor pentru Form-ul care se ocupa de afisarea rezultatului.
        /// </summary>
        /// <param name="mainForm">
        /// O referinta la form-ul de log-in pentru a ne putea intoarce la el in caz ca user-ul doreste sa dea log-out.
        /// </param>
        /// <param name="user">
        /// Obiect de tip user care contine informatiile persoanei care tocmai a terminat testul.
        /// </param>
        /// <param name="punctaj">
        /// Scorul obtinut la chestionarul completat anterior.
        /// </param>
        public FormRezultat(Form mainForm, User user,int punctaj)
        {
            InitializeComponent();
            _user = user;
            _punctaj = punctaj;
            if (_formLogin == null)
            {
                _formLogin = mainForm;
            }

        }
        /// <summary>
        /// Metoda de onLoad. Afiseaza istoricul persoanei, in caz ca acesta exista, si scorul curent.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormRezultat_Load(object sender, EventArgs e)
        {
            string history=Parser.WriteAndGetHistory("history.txt", _user, _punctaj);
            string[] punctaje = history.Split(',');
            int i = 0;
            foreach(string scor in punctaje)
            { 
                chartHistory.Series["Score"].Points.AddXY((i++).ToString(), scor);
            }

            if (_punctaj < 5)
            {
                labelRezultat.Text = "Your score is " + _punctaj + " out of 10 questions. Better luck next time!";
            }
            else if(_punctaj<10)
            {
                labelRezultat.Text = "Your score is " + _punctaj + " out of 10 questions. Congratulations!";
            }
            else
            {
                labelRezultat.Text = "Your score is " + _punctaj + " out of 10 questions. You've outdone yourself!";
            }
        }

        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul doreste sa se intoarca la meniul de log-in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            this.Close();
            _formLogin.Show();
        }

        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul doreste sa inceapa un nou chestionar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRedo_Click(object sender, EventArgs e)
        {
            Form formChestionar = new FormChestionar(_formLogin, _user);
            formChestionar.Show();
            this.Close();
            
        }
    }
}

/**************************************************************************
 *                                                                        *
 *  File:        FormRegisterAdmin.cs                                     *
 *  Copyright:   (c) 2022, Ungureanu Mihai-Vladut                         *
 *  Description: Clasa de tip Windows Forms, folosita pentru a            *
 *               realiza interfata prin care un admin adauga un           *
 *               nou user cu drepturi privilegiate.                       *
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
    /// Form-ul care se deschide atunci cand un utilizator de tip admin doreste sa creeze un nou cont cu privilegii de admin.
    /// </summary>
    public partial class FormRegisterAdmin : Form
    {
        public FormRegisterAdmin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand admin-ul adauga un nou user cu drepturi privilegiate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUserAdmin.Text;
                string password = textBoxPasswordAdmin.Text;
                if (username == "" || password == "")
                {
                    throw new RegisterException("Utilizator sau parola nule!");
                }
                password = Cryptography.HashString(password);
                List<User> users = Parser.GetUsers("utilizatori.txt");
                foreach (User user in users)
                {
                    if (user.GetUsername == username)
                    {
                        throw new RegisterException("Username existent!");
                    }
                }
                users.Add(new User(username, password, true));
                Parser.WriteUserToFile("utilizatori.txt", new User(username, password, true));
                MessageBox.Show("Administrator inregistrat cu succes!");
            }
            catch (RegisterException err)
            {
                MessageBox.Show(err.GetMessage);
            }
            finally
            {
                
                this.Close();
            }
        }
    }
}

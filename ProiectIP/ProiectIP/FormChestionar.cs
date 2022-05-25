/**************************************************************************
 *                                                                        *
 *  File:        FormAdmin.cs                                             *
 *  Copyright:   (c) 2022, Ionita Bogdan-Marian                           *
 *  Description: Clasa de tip Windows Forms, folosita pentru a            *
 *               realiza interfata unui user normal, cu ajutorul          *
 *               careia se completeaza chestionarul.                      *
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
    /// Form-ul secundar, utilizat de userii simpli, care doresc sa raspunda la un chestionar cu 10 intrebari.
    /// </summary>
    public partial class FormChestionar : Form
    {
        //User-ul curent
        private User _user;
        //Referinta catre form-ul principal, cel care asigura logica de log-in
        private Form _formLogin=null;
        //Lista de intrebari disponibile
        private List<Intrebare> _intrebari;
        //Indexul raspunsului selectat ca fiind corect
        private int _raspunsSelectat = -1;
        //Variabila random prin care vom alege o intrebare din lista de intrebari.
        private int _random;
        //Punctajul curent al utilizatorului.
        private int _punctaj = 0;
        //Variabila care retine numarul intrebarii la care a ajuns utilizatorul.
        private int _numarIntrebareCurenta = 0;
        //Variabila de timer. Atunci cand ajunge la 0 testul se inchide.
        private int _timeLeft = 300;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mainForm">
        /// Form-ul principal care contine logica de log-in
        /// </param>
        /// <param name="user">
        /// User-ul care a pornit testul
        /// </param>
        public FormChestionar(Form mainForm,User user)
        {
            InitializeComponent();
            _user = user;
            if (_formLogin == null)
            {
                _formLogin = mainForm;
                
            }

        }
        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul alege un raspuns ca fiind corect.
        /// Butonul selectat este evidentiat prin culoarea verde iar indexul raspunsului selectat se schimba in 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonA_Click(object sender, EventArgs e)
        {
            ResetColor();
            buttonA.BackColor = Color.Green;
            this._raspunsSelectat = 0;
        }
        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul alege un raspuns ca fiind corect.
        /// Butonul selectat este evidentiat prin culoarea verde iar indexul raspunsului selectat se schimba in 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonB_Click(object sender, EventArgs e)
        {
            ResetColor();
            buttonB.BackColor = Color.Green;
            this._raspunsSelectat = 1;
        }
        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul alege un raspuns ca fiind corect.
        /// Butonul selectat este evidentiat prin culoarea verde iar indexul raspunsului selectat se schimba in 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            ResetColor();
            buttonC.BackColor = Color.Green;
            this._raspunsSelectat = 2;
        }
        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul alege un raspuns ca fiind corect.
        /// Butonul selectat este evidentiat prin culoarea verde iar indexul raspunsului selectat se schimba in 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonD_Click(object sender, EventArgs e)
        {
            ResetColor();
            buttonD.BackColor = Color.Green;
            this._raspunsSelectat = 3;
        }

        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul doreste sa paraseasca chestionarul si sa se intoarca la meniul de log-in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisconect_Click(object sender, EventArgs e)
        {

            this.Close();
            _formLogin.Show();
        }

        /// <summary>
        /// Metoda de onLoad a chestionarului prin care se salveaza lista de intrebari si se afiseaza o prima intrebare.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormChestionar_Load(object sender, EventArgs e)
        {
            showTimer(_timeLeft);
            labelUser.Text = "Good luck : " + _user.GetUsername;
            _intrebari=Parser.GetIntrebari("intrebari.txt");
            Random r = new Random();
            _random = r.Next(0, this._intrebari.Count);
            AfiseazaIntrebare(_intrebari[_random]);
            
        }

        /// <summary>
        /// Metoda care schimba text-ul din richTextBox atunci cand se trece la o alta intrebare.
        /// </summary>
        /// <param name="intrebare"></param>
        private void AfiseazaIntrebare(Intrebare intrebare)
        {
            richTextBoxQuestionUser.Clear();
            List<string> raspunsuri = intrebare.GetRaspunsuri;
            richTextBoxQuestionUser.SelectionFont = new Font("Arial", 22, FontStyle.Bold);
            richTextBoxQuestionUser.AppendText(intrebare.GetIntrebare + "\n");
            richTextBoxQuestionUser.SelectionFont = new Font("Arial", 15, FontStyle.Regular);
            richTextBoxQuestionUser.AppendText("A. " + raspunsuri[0]+"\n");
            richTextBoxQuestionUser.SelectionFont = new Font("Arial", 15, FontStyle.Regular);
            richTextBoxQuestionUser.AppendText("B. " + raspunsuri[1] + "\n");
            richTextBoxQuestionUser.SelectionFont = new Font("Arial", 15, FontStyle.Regular);
            richTextBoxQuestionUser.AppendText("C. " + raspunsuri[2] + "\n");
            richTextBoxQuestionUser.SelectionFont = new Font("Arial", 15, FontStyle.Regular);
            richTextBoxQuestionUser.AppendText("D. " + raspunsuri[3] + "\n");

        }
        /// <summary>
        /// Metoda care reseteaza culoarea butoanelor cand se trece la o noua intrebare.
        /// </summary>
        private void ResetColor()
        {
            buttonA.BackColor = SystemColors.Control;
            buttonB.BackColor = SystemColors.Control;
            buttonC.BackColor = SystemColors.Control;
            buttonD.BackColor = SystemColors.Control;
        }
        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul trece la o noua intrebare.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                if(_raspunsSelectat==-1)
                {
                    throw new Exception("Nu a fost selectat niciun raspuns!");
                }
                if(_raspunsSelectat==_intrebari[_random].GetIndexRaspunsCorect)
                {
                    _punctaj += 1;
                }
                
                ResetColor();
                _numarIntrebareCurenta += 1;
                //se sterge intrebarea la care tocmai s-a raspuns din lista cu intrebari pentru a nu se repeta.
                _intrebari.RemoveAt(_random);
                //se obtine o noua intrebare 
                Random r = new Random();
                _random = r.Next(0, _intrebari.Count);
                AfiseazaIntrebare(_intrebari[_random]);
                _raspunsSelectat = -1;
                labelNumber.Text=(_numarIntrebareCurenta+1).ToString()+"/10";
                //Daca se apasa butonul de onNext atunci cand utilizatorul se afla la ultima intrebare se va deschide un nou form pentru a afisa rezultatul.
                if (_numarIntrebareCurenta > 9)
                {
                    Form formRezultat = new FormRezultat(_formLogin, _user, _punctaj);
                    formRezultat.Show();
                    this.Close();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        /// <summary>
        /// Metoda care se ocupa decrementarea timer-ului la fiecare secunda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            showTimer(_timeLeft);
            //Daca timer-ul devine negativ, chestionarul se inchide si apare un nou Form pentru a afisa rezultatul.
            if (_timeLeft == -1)
            {
                Form formRezultat = new FormRezultat(_formLogin, _user, _punctaj);
                formRezultat.Show();
                this.Close();
            }
        }
        
        /// <summary>
        /// Metoda folosita pentru a afisa corect timpul ramas pe interfata.
        /// </summary>
        /// <param name="timeLeft"></param>
        private void showTimer(int timeLeft)
        {
            int minute = timeLeft / 60;
            int secunde = timeLeft - minute * 60;
            if (secunde < 10)
            {
                labelTimer.Text = minute + ":" + "0"+ secunde ;
            }
           
            else
            {
                labelTimer.Text = minute + ":" + secunde;
            }
        }
    }
}

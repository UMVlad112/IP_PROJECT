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
    public partial class FormRezultat : Form
    {
        private Form _formLogin;
        private User _user;
        private int _punctaj;
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

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            this.Close();
            _formLogin.Show();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            Form formChestionar = new FormChestionar(_formLogin, _user);
            formChestionar.Show();
            this.Close();
            
        }
    }
}

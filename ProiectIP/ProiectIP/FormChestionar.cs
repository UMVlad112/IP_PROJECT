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
    public partial class FormChestionar : Form
    {
        private User _user;
        private Form _formLogin=null;
        private List<Intrebare> _intrebari;
        private int _raspunsSelectat = -1;
        private int _random;
        private int _punctaj = 0;
        private int _numarIntrebareCurenta = 0;
        public FormChestionar(Form mainForm,User user)
        {
            InitializeComponent();
            _user = user;
            if (_formLogin == null)
            {
                _formLogin = mainForm;
                
            }

        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            ResetColor();
            buttonA.BackColor = Color.Green;
            this._raspunsSelectat = 0;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            ResetColor();
            buttonB.BackColor = Color.Green;
            this._raspunsSelectat = 1;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ResetColor();
            buttonC.BackColor = Color.Green;
            this._raspunsSelectat = 2;
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ResetColor();
            buttonD.BackColor = Color.Green;
            this._raspunsSelectat = 3;
        }

        private void buttonDisconect_Click(object sender, EventArgs e)
        {

            this.Close();
            _formLogin.Show();
        }

        private void FormChestionar_Load(object sender, EventArgs e)
        {
            _intrebari=Parser.GetIntrebari("intrebari.txt");
            Random r = new Random();
            _random = r.Next(0, this._intrebari.Count);
            AfiseazaIntrebare(_intrebari[_random]);
            //_intrebari.RemoveAt(_random);
        }

        private void AfiseazaIntrebare(Intrebare intrebare)
        {
            List<string> raspunsuri = intrebare.GetRaspunsuri;
            richTextBoxQuestionUser.Text = intrebare.GetIntrebare+"\n";
            richTextBoxQuestionUser.Text += "A." + raspunsuri[0] + "\n";
            richTextBoxQuestionUser.Text += "B." + raspunsuri[1] + "\n";
            richTextBoxQuestionUser.Text += "C." + raspunsuri[2] + "\n";
            richTextBoxQuestionUser.Text += "D." + raspunsuri[3] + "\n";

        }

        private void ResetColor()
        {
            buttonA.BackColor = SystemColors.Control;
            buttonB.BackColor = SystemColors.Control;
            buttonC.BackColor = SystemColors.Control;
            buttonD.BackColor = SystemColors.Control;
        }

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
                    MessageBox.Show("RaspunsCorect");
                    _punctaj += 1;
                }
                else
                {
                    MessageBox.Show("RaspunsGresit");
                }
                ResetColor();
                _numarIntrebareCurenta += 1;
                _intrebari.RemoveAt(_random);
                Random r = new Random();
                _random = r.Next(0, _intrebari.Count);
                AfiseazaIntrebare(_intrebari[_random]);
                _raspunsSelectat = -1;
                labelNumber.Text=(_numarIntrebareCurenta+1).ToString()+"/10";

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

       
    }
}

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
    public partial class FormAdmin : Form
    {
        private List<TextBox> _textBoxes;
        private List<RadioButton> _radioButtons  ;
        private Form _formLogin;
        private User _user;

        public FormAdmin( Form mainForm,User user)
        {
            InitializeComponent();
            _user = user;
            if (_formLogin == null)
            {
                _formLogin = mainForm;
            }
            
        }

        

        private void textBoxAnswer1_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswer1.Text == "Write your answer here.....")
            {
                textBoxAnswer1.Text = "";
                textBoxAnswer1.ForeColor = Color.Black;
            }
        }
        private void textBoxAnswer2_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswer2.Text == "Write your answer here.....")
            {
                textBoxAnswer2.Text = "";
                textBoxAnswer2.ForeColor = Color.Black;
            }
        }
        private void textBoxAnswer3_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswer3.Text == "Write your answer here.....")
            {
                textBoxAnswer3.Text = "";
                textBoxAnswer3.ForeColor = Color.Black;
            }
        }
        private void textBoxAnswer4_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswer4.Text == "Write your answer here.....")
            {
                textBoxAnswer4.Text = "";
                textBoxAnswer4.ForeColor = Color.Black;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string Intrebare = richTextBoxQuestionAdmin.Text;
            string raspuns1 = textBoxAnswer1.Text;
            string raspuns2 = textBoxAnswer2.Text;
            string raspuns3 = textBoxAnswer3.Text;
            string raspuns4 = textBoxAnswer4.Text;
            int indexRaspunsCorect=0;
            try
            {
                if (Intrebare == "" || raspuns1 == "" || raspuns2 == "" || raspuns3 == "" || raspuns4 == "")
                {
                    throw new InregistrareIntrebareException("Va rugam completati toate campurile!");
                }
                int i = 0;
                foreach(RadioButton button in groupBoxAnswers.Controls.OfType<RadioButton>())
                {
                    if(button.Checked==true)
                    {
                        i = 3 - i;  //primul radio button are valoarea 3;
                        indexRaspunsCorect = i;
                        break;
                    }
                    i++;
                    
                }
                Parser.WriteIntrebareToFile("intrebari.txt",new Intrebare(Intrebare, raspuns1, raspuns2, raspuns3, raspuns4, indexRaspunsCorect));
                MessageBox.Show("Intrebarea a fost adaugata cu succes!");
                
            }
            catch(InregistrareIntrebareException err)
            {
                MessageBox.Show(err.GetMessage);
            }
            finally
            {
                richTextBoxQuestionAdmin.Clear();
                foreach (TextBox button in groupBoxAnswers.Controls.OfType<TextBox>())
                {
                    button.Clear();
                }
                radioButtonAnswer1.Checked = true;
            }

           
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonDisconectAdmin_Click(object sender, EventArgs e)
        {

            _formLogin.Enabled = false;
            _formLogin.Enabled = true;
            this.Close();
            _formLogin.Show();
           
        }

        private void buttonRegisterAdmin_Click(object sender, EventArgs e)
        {
            Form RegisterNewAdmin = new FormRegisterAdmin();
            RegisterNewAdmin.ShowDialog();
        }
    }
}

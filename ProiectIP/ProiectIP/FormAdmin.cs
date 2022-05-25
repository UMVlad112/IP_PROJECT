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
    /// Form-ul secundar, utilizat de userii cu drept de admin.
    /// </summary>
    public partial class FormAdmin : Form
    {
        //Lista de textBoxes pentru a citi mai usor raspunsurile.
        private List<TextBox> _textBoxes;
        //Lista de radioButtons pentru a afla mai usor care este raspunsul selectat ca fiind corect.
        private List<RadioButton> _radioButtons  ;
        //Referinta catre main form-ul care realizeaza logica de log-in.
        private Form _formLogin;
        //User-ul curent.
        private User _user;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mainForm">
        /// Referinta catre main form-ul care realizeaza logica de log-in. 
        /// </param>
        /// <param name="user">
        /// User-ul curent
        /// </param>
        public FormAdmin( Form mainForm,User user)
        {
            InitializeComponent();
            _user = user;
            if (_formLogin == null)
            {
                _formLogin = mainForm;
            }
            
        }

        
        /// <summary>
        /// Metoda folosita pentru a afisa un text de tip placeholder pentru a avea un user experienta mai bun.
        /// Cand se apasa pe textBox pentru a introduce un input, text-ul placeholder dispare.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAnswer1_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswer1.Text == "Write your answer here.....")
            {
                textBoxAnswer1.Text = "";
                textBoxAnswer1.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Metoda folosita pentru a afisa un text de tip placeholder pentru a avea un user experienta mai bun.
        /// Cand se apasa pe textBox pentru a introduce un input, text-ul placeholder dispare.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAnswer2_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswer2.Text == "Write your answer here.....")
            {
                textBoxAnswer2.Text = "";
                textBoxAnswer2.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Metoda folosita pentru a afisa un text de tip placeholder pentru a avea un user experienta mai bun.
        /// Cand se apasa pe textBox pentru a introduce un input, text-ul placeholder dispare.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAnswer3_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswer3.Text == "Write your answer here.....")
            {
                textBoxAnswer3.Text = "";
                textBoxAnswer3.ForeColor = Color.Black;
            }
        }
        /// <summary>
        /// Metoda folosita pentru a afisa un text de tip placeholder pentru a avea un user experienta mai bun.
        /// Cand se apasa pe textBox pentru a introduce un input, text-ul placeholder dispare.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAnswer4_Enter(object sender, EventArgs e)
        {
            if (textBoxAnswer4.Text == "Write your answer here.....")
            {
                textBoxAnswer4.Text = "";
                textBoxAnswer4.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand un admin doreste sa introduca o noua intrebare.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                //Se cauta radioButton-ul din dreptul raspunsului considerat corect.
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


        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul doreste sa se intoarca la meniul de log-in.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisconectAdmin_Click(object sender, EventArgs e)
        {

            _formLogin.Enabled = false;
            _formLogin.Enabled = true;
            this.Close();
            _formLogin.Show();
           
        }
        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand un admin doreste sa deschida Form-ul prin care se poate adauga un user cu drepturi privilegiate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegisterAdmin_Click(object sender, EventArgs e)
        {
            Form RegisterNewAdmin = new FormRegisterAdmin();
            RegisterNewAdmin.ShowDialog();
        }

       
    }
}

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
        private Form formLogin;

        public FormAdmin( Form mainForm)
        {
            InitializeComponent();
            formLogin = mainForm;
           
            
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
            
           
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonDisconectAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin.Show();
        }
    }
}

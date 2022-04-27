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
        private Form _formLogin=null;
        public FormChestionar(Form mainForm)
        {
            InitializeComponent();
            if (_formLogin == null)
            {
                _formLogin = mainForm;
            }

        }

        private void buttonA_Click(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {

        }

        private void buttonDisconect_Click(object sender, EventArgs e)
        {

            this.Close();
            _formLogin.Show();
        }
    }
}

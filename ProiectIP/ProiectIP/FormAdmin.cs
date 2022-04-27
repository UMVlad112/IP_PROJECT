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
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void textBoxAnswer1_TextChanged(object sender, EventArgs e)
        {
            if(textBoxAnswer1.Text== "Write your answer here.....")
            {
                textBoxAnswer1.Text = "";
            }
        }
    }
}

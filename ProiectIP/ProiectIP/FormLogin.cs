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
    public partial class FormLogin : Form
    {
        private List<User> _users;
        private Form _secondaryForm;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUserName.Text;
                string password = textBoxPassword.Text;
                if(username=="" || password=="")
                {
                    throw new RegisterException("Utilizator sau parola nule!");
                }
                password = Cryptography.HashString(password);
                foreach (User user in _users)
                {
                    if (user.GetUsername == username)
                    {
                        throw new RegisterException("Utilizator existent!");
                    }
                }
                _users.Add(new User(username, password, false));
                Parser.WriteUserToFile("utilizatori.txt", new User(username, password, false));
                MessageBox.Show("Utilizator inregistrat cu succes!");
            }
            catch (RegisterException err)
            {
                MessageBox.Show(err.GetMessage);
            }
            finally
            {
                textBoxUserName.Clear();
                textBoxPassword.Clear();
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Console.WriteLine("da");
            if(_users==null)
            {
                try
                {
                    _users = new List<User>();
                    _users = Parser.GetUsers("utilizatori.txt");
                }
                catch(Exception err)
                {
                    Console.WriteLine("Fisier gol");
                }
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            bool isUser = false;
            try
            {
                if (username == "" || password == "")
                {
                    throw new LoginException("Utilizator sau parola nule!");
                }
                password = Cryptography.HashString(password);
                foreach (User user in _users)
                {
                    if (user.GetUsername == username && user.GetHashPassword == password)
                    {
                        isUser = true;
                        _secondaryForm = FormCreator.CreateForm(this, user);
                        this.Hide();
                        _secondaryForm.Show();
                        break;
                    }

                }
                if (!isUser)
                {
                    throw new LoginException("Username sau parola gresite!");
                }
 
            }
            catch(LoginException err)
            {
                MessageBox.Show(err.GetMessage);
            }
            finally
            {
                textBoxUserName.Clear();
                textBoxPassword.Clear();
            }

        }

        private void FormLogin_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled == true)
            {
                Console.WriteLine("merge");
                _users = Parser.GetUsers("utilizatori.txt");
            }
        }

    }
}

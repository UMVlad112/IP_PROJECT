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
    /// Form-ul principal al aplicatiei, prin care user-ul acceseaza chestionarele.
    /// </summary>
    public partial class FormLogin : Form
    {
        private List<User> _users;
        private Form _secondaryForm;
        //Referinta catre un al doilea form, acesta fiind de tip FormChestionar, atunci cand user-ul este simplu, sau FormAdmin pentru userii privilegiati.
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda de onClick apelata atunci cand utilizatorul doreste sa-si creeze un cont personal pentru a accesa aplicatia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                //Parola se trimite sub forma de hashString pentru a oferi securitate user-ului.
                password = Cryptography.HashString(password);
                
                foreach (User user in _users)
                {
                    if (user.GetUsername == username)
                    {
                        throw new RegisterException("Utilizator existent!");
                    }
                }
                //Daca user-ul a completat corect campurile necesare, si numele de utilizator nu mai exista in baza de date, contul se creeaza si se salveaza in fisier.
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

        /// <summary>
        /// Metoda de onLoad al Form-ului care citeste toti userii din fisier si ii stocheaza intr-o lista de "User".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
            
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

        /// <summary>
        /// Metoda de onClick care se apeleaza atunci cand utilizatorul doreste sa intre in cont si sa inceapa un chestionar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metoda folosita pentru a resincroniza lista de utilizatori, dupa ce se adauga un nou user de catre admin.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_EnabledChanged(object sender, EventArgs e)
        {
            if (this.Enabled == true)
            {
                _users = Parser.GetUsers("utilizatori.txt");
            }
        }

    }
}

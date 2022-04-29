using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectIP
{
    class Parser
    {
        //private const string _fisierUsers=;
        //private const string _fisierIntrebari=;
        public static List<User> GetUsers(string file)
        {
            List<User> users = new List<User>();
            StreamReader sr = new StreamReader(file);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] toks = line.Split('\t');
                User user = new User(toks[0], toks[1], toks[2]=="True");
                users.Add(user);
            }
            sr.Close();
            return users;
        }

        public static List<Intrebare> GetIntrebari(string file)
        {
            List<Intrebare> intrebari = new List<Intrebare>();
            StreamReader sr = new StreamReader(file);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                line = Cryptography.Decrypt(line, "hashIntrebare");
                string[] toks = line.Split('\t');
                Intrebare intrebare = new Intrebare(toks[0], toks[1], toks[2],toks[3],toks[4],int.Parse(toks[5]));
                intrebari.Add(intrebare);
            }
            sr.Close();
            return intrebari;
        }

        public static void WriteIntrebareToFile(string file,Intrebare intrebare)
        {
            List<string> raspunsuri = intrebare.GetRaspunsuri;
            string line = intrebare.GetIntrebare + "\t" + raspunsuri[0] + "\t" + raspunsuri[1] + "\t" + raspunsuri[2] + "\t" + raspunsuri[3] + "\t" + intrebare.GetIndexRaspunsCorect;
            line=Cryptography.Encrypt(line, "hashIntrebare");
            using (StreamWriter w = File.AppendText(file))
            {
                w.WriteLine(line);
            }

        }

        public static void WriteUserToFile(string file,User user)
        {
            string line = user.GetUsername + "\t" + user.GetHashPassword + "\t" + user.GetIsAdmin;
            using (StreamWriter w = File.AppendText(file))
            {
                w.WriteLine(line);
            }
        }
    }

}

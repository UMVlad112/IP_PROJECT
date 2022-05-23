using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProiectIP
{
    /// <summary>
    /// Clasa utilizata pentru lucrul cu fisere; 
    /// </summary>
    class Parser
    {
        /// <summary>
        /// Metoda care citeste din fisier toti userii inregistrati atunci cand se deschide aplicatia
        /// </summary>
        /// <param name="file">
        /// Calea catre fisierul cu utilizatori
        /// </param>
        /// <returns>
        /// Lista cu utilizatorii inregistrati
        /// </returns>
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

        /// <summary>
        /// Metoda care extrage toate intrebarile din fisier atunci cand se deschid aplicatia
        /// </summary>
        /// <param name="file">
        /// Calea catre fisierul in care sunt stocate intrebarile
        /// </param>
        /// <returns>
        /// Pool-ul de intrebari 
        /// </returns>
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

        /// <summary>
        /// Functie pentru a adauga o noua intrebare ( sub forma criptata) in fisierul cu intrebari. Doar un utilizator cu drepturi de admin poate face acest lucru!
        /// </summary>
        /// <param name="file">
        /// calea catre fisierul cu intrebari
        /// </param>
        /// <param name="intrebare">
        /// Obiectul de tip Intrebare, care urmeaza a fi salvat
        /// </param>
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

        /// <summary>
        /// Metoda utilizata pentru a adauga un nou user in fisierul ce contine utilizatorii inregistrati
        /// </summary>
        /// <param name="file">
        /// Calea catre fisierul cu utilizatori
        /// </param>
        /// <param name="user">
        /// Obiect de tipul User ce urmeaza a fi scris in fisier
        /// </param>
        public static void WriteUserToFile(string file,User user)
        {
            string line = user.GetUsername + "\t" + user.GetHashPassword + "\t" + user.GetIsAdmin;
            using (StreamWriter w = File.AppendText(file))
            {
                w.WriteLine(line);
            }
        }

        /// <summary>
        /// Metoda folosita pentru a obtine si actualiza istoricul unui utilizator. (Punctajele obtinute la chestionarele completate anterior)
        /// </summary>
        /// <param name="file">
        /// Calea catre fisierul cu istoricul utilizatorilor
        /// </param>
        /// <param name="user">
        /// Obiect de tipul User ce reprezinta userul care tocmai a terminat de completat testul
        /// </param>
        /// <param name="punctaj">
        /// Punctajul obtinut
        /// </param>
        /// <returns>
        /// Noul istoric , obtinut dupa actualizarea cu punctajul de la testul curent
        /// </returns>
        public static string WriteAndGetHistory(string file,User user, int punctaj)
        {
            string istoric = "";
            StreamReader sr = new StreamReader(file);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] toks = line.Split('\t');
                if (toks[0] == user.GetUsername)
                {
                    istoric = toks[1];
                    break;
                }
                

            }
            sr.Close();
            string toInsert = "";
            Console.WriteLine(istoric);
            if (istoric == "")
            {
                using (StreamWriter w = File.AppendText(file))
                {
                    toInsert = returnScore(punctaj);
                    w.WriteLine(user.GetUsername + "\t"+toInsert);
                }
            }
            else
            {
                File.WriteAllLines(file, File
                .ReadLines(file)
                .Where(myLine => !myLine.StartsWith(user.GetUsername))
                .ToArray());

                toInsert = returnScore(istoric, punctaj);
                using (StreamWriter w = File.AppendText(file))
                {
                    w.WriteLine(user.GetUsername + "\t" + toInsert);
                }
            }
            return toInsert;

        }
        /// <summary>
        /// Creaza un nou istoric pentru un utilizator care se afla la primul test
        /// </summary>
        /// <param name="punctaj">
        /// Punctajul obtinut
        /// </param>
        /// <returns>
        /// Noul istoric al utilizatorului curent
        /// </returns>
        private static string returnScore(int punctaj)
        {
            string toInsert = "";
            for (int i = 0; i < 10; i++)
            {
                if (i == punctaj)
                {
                    toInsert += "1,";
                }
                else
                {
                    toInsert += "0,";
                }
            }
            if (10 == punctaj)
            {
                toInsert += "1";
            }
            else
            {
                toInsert += "0";
            }
            return toInsert;
        }

        /// <summary>
        /// Metoda pentru updatarea istoricului unui utilizator care nu se afla la primul test;
        /// </summary>
        /// <param name="istoric">
        /// Istoricul anterior completarii acestui test
        /// </param>
        /// <param name="punctaj">
        /// Punctajul obtinut la testul curent
        /// </param>
        /// <returns>
        /// Noul istoric al utilizatorului curent
        /// </returns>
        private static string returnScore(string istoric, int punctaj)
        {
            string toInsert = "";
            string[] punctaje = istoric.Split(',');
            punctaje[punctaj] = (int.Parse(punctaje[punctaj]) + 1).ToString();
            for (int i = 0; i < 10; i++)
            {
                toInsert += punctaje[i] + ",";
            }
            toInsert += punctaje[10];
            return toInsert;
        }
    }
    

}

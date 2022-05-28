using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UserAdminTest1()
        {
            ProiectIP.User a=new ProiectIP.User("a", "b", true);
            Assert.AreEqual(a.GetIsAdmin,true);
        }

        [TestMethod]
        public void UserAdminTest2()
        {
            ProiectIP.User a = new ProiectIP.User("a", "b", false);
            Assert.AreEqual(a.GetIsAdmin, true);
        }

        [TestMethod]
        public void UserGettersTest1()
        {
            ProiectIP.User a = new ProiectIP.User("a", "b", false);
            Assert.AreEqual(a.GetUsername, "a");
        }

        [TestMethod]
        public void UserGettersTest2()
        {
            ProiectIP.User a = new ProiectIP.User("a", "b", false);
            Assert.AreEqual(a.GetHashPassword, "b");
        }

        [TestMethod]
        public void CryptographyTest()
        {
            string parola = "parola";
            string hashParola = ProiectIP.Cryptography.Encrypt(parola, "parolaPtHash");
            Assert.AreEqual(ProiectIP.Cryptography.Decrypt(hashParola,"parolaPtHash"), parola);
        }

        [TestMethod]
        public void CryptographyTest2()
        {
            string parola = "parola";
            string hashParola = ProiectIP.Cryptography.Encrypt(parola, "parolaPtHash1");
            Assert.AreEqual(ProiectIP.Cryptography.Decrypt(hashParola, "parolaPtHash2"), parola);
        }

        [TestMethod]
        public void IntrebareTest1()
        {
            ProiectIP.Intrebare intrebare = new ProiectIP.Intrebare("intrebare", "raspuns1", "raspuns2", "raspuns3", "raspuns4", 0);
            Assert.AreEqual(intrebare.GetIndexRaspunsCorect, 0);
        }
        [TestMethod]
        public void IntrebareTest2()
        {
            ProiectIP.Intrebare intrebare = new ProiectIP.Intrebare("intrebare", "raspuns1", "raspuns2", "raspuns3", "raspuns4", 0);
            Assert.AreEqual(intrebare.GetIntrebare, "intrebare");
        }
        [TestMethod]
        public void IntrebareTest3()
        {
            ProiectIP.Intrebare intrebare = new ProiectIP.Intrebare("intrebare", "raspuns1", "raspuns2", "raspuns3", "raspuns4", 0);
            Assert.AreEqual(intrebare.GetRaspunsCorect, "raspuns1");
        }

        [TestMethod]
        public void IntrebareTest4()
        {
            ProiectIP.Intrebare intrebare = new ProiectIP.Intrebare("intrebare", "raspuns1", "raspuns2", "raspuns3", "raspuns4", 0);
            Assert.AreEqual(intrebare.GetRaspunsCorect, "raspuns2");
        }

        [TestMethod]
        public void IntrebareTest5()
        {
            ProiectIP.Intrebare intrebare = new ProiectIP.Intrebare("intrebare", "raspuns1", "raspuns2", "raspuns3", "raspuns4", 0);
            List<string> raspunsuri = new List<string>();
            raspunsuri.Add("raspuns1");
            raspunsuri.Add("raspuns2");
            raspunsuri.Add("raspuns3");
            raspunsuri.Add("raspuns4");
            CollectionAssert.AreEqual(intrebare.GetRaspunsuri, raspunsuri);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void ParserTest1()
        {
            ProiectIP.Parser.GetUsers("fisierInexistent.txt");
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void ParserTest2()
        {
            ProiectIP.Parser.GetIntrebari("fisierInexistent.txt");
        }

        [TestMethod]
        public void ParserTest3()
        {
            ProiectIP.Intrebare intrebare = new ProiectIP.Intrebare("Care este capitala romaniei?", "Iasi", "Bucuresti", "Cluj", "Timisoara", 1);
            List<ProiectIP.Intrebare> list = new List<ProiectIP.Intrebare>();
            list.Add(intrebare);
            
            List<ProiectIP.Intrebare> listaFisier = ProiectIP.Parser.GetIntrebari("intrebari.txt");
            Assert.AreEqual(list[0].GetIndexRaspunsCorect, listaFisier[0].GetIndexRaspunsCorect);
            Assert.AreEqual(list[0].GetIntrebare, listaFisier[0].GetIntrebare);
            CollectionAssert.AreEqual(list[0].GetRaspunsuri, listaFisier[0].GetRaspunsuri);
        }
        [TestMethod]
        public void ParserTest4()
        {
            ProiectIP.User user = new ProiectIP.User("test2", ProiectIP.Cryptography.HashString("test2"), false);
           List<ProiectIP.User> userFisier = ProiectIP.Parser.GetUsers("utilizatori.txt");
            Assert.AreEqual(user.GetUsername, userFisier[0].GetUsername);
            Assert.AreEqual(user.GetHashPassword, userFisier[0].GetHashPassword);
            Assert.AreEqual(user.GetIsAdmin, userFisier[0].GetIsAdmin);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void ParserTest5()
        {
            ProiectIP.Parser.WriteAndGetHistory("fisierInexistent.txt",new ProiectIP.User("test","test",false),0);
        }

        [TestMethod]
        public void ParserTest6()
        {
            Assert.AreEqual(ProiectIP.Parser.returnScore(5), "0,0,0,0,0,1,0,0,0,0,0");
        }

        [TestMethod]
        public void ParserTest7()
        {
            Assert.AreEqual(ProiectIP.Parser.returnScore("1,0,0,0,0,0,0,0,0,0,0",5), "1,0,0,0,0,1,0,0,0,0,0");
        }

        [TestMethod]
        [Timeout(2000)]  // Milliseconds
        public void ParserTimeout1()
        {
            ProiectIP.Parser.GetUsers("utilizatori.txt");
        }

        [TestMethod]
        [Timeout(2)]  // Milliseconds
        public void ParserTimeout2()
        {
            ProiectIP.Parser.GetIntrebari("intrebari.txt");
        }


    }
}

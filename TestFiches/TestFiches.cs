using System;
using Cl�ture_des_fiches;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestFiches
{
    [TestClass]
    public class TestFiches
    {
        /*
         * Classe de tests
         * 
         * **/

        [TestMethod()]
        public void testGetMoisPrecedent()
        {
            //valeur du mois pr�c�dent:
            string numMoisPrecedent = "03";
            Assert.AreEqual(numMoisPrecedent, GestionDates.getMoisPrecedent(), 
                            "Le mois pr�c�dent par rapport � la date actuelle n'est pas le bon.");
        }

        [TestMethod()]
        public void testGetMoisPrecedentSurcharge()
        {
            //valeur du mois pr�c�dent:
            string numMoisPrecedent = "12";
            DateTime uneDate = new DateTime(2021, 01, 30);
            Assert.AreEqual(numMoisPrecedent, GestionDates.getMoisPrecedent(uneDate), 
                            "Le mois pr�c�dent par rapport � la date entr�e n'est pas le bon.");
        }

        [TestMethod()]
        public void testGetMoisSuivant()
        {
            //valeur du mois suivant:
            string numMoisSuivant = "05";
            Assert.AreEqual(numMoisSuivant, GestionDates.getMoisSuivant(), 
                            "Le mois suivant par rapport � la date actuelle n'est pas le bon.");
        }

        [TestMethod()]
        public void testGetMoisSuivantSurcharge()
        {
            //valeur du mois suivant:
            string numMoisSuivant = "05";
            DateTime uneDate = new DateTime(2021, 04, 30);
            Assert.AreEqual(numMoisSuivant, GestionDates.getMoisSuivant(uneDate), 
                            "Le mois suivant par rapport � la date entr�e n'est pas le bon.");
        }

        //test entre(int uneDate, int uneAutreDate)
        [TestMethod()]
        public void testEntre()
        {
            Assert.AreEqual(true, GestionDates.entre(1, 10), "Le test a �chou�.");
        }

        //test entre(int uneDate, int uneAutreDate) surcharge
        [TestMethod()]
        public void testEntreSurcharge()
        {
            DateTime uneDate = new DateTime(2021, 03, 21);
            Assert.AreEqual(true, GestionDates.entre(20, 31, uneDate), "Le test a �chou�");
        }
    }
}

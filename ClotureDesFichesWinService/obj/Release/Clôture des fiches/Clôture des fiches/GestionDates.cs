using System;
using System.Collections.Generic;
using System.Text;

namespace Clôture_des_fiches
{
    abstract public class GestionDates
    {
        /*
         * méthode retournant le mois précédent le mois actuel au format "MM"
         * 
         * **/
        public static string getMoisPrecedent()
        {
            //recupération du mois présent dans une valeur
            string moisPresent = (DateTime.Now.ToString("MM/dd/yyyy")).Substring(0, 2);

            //calcul du mois précédent
            string moisPrecedent = (int.Parse(moisPresent) - 1).ToString();
          

            //vérification du format à double chiffre (ex: "01", "10"...)
            if (int.Parse(moisPrecedent) < 10 && int.Parse(moisPrecedent) != 0)
            {      //--->>> POSSIBLE ERREUR ICI "<"? "<="?
                moisPrecedent = moisPrecedent.Insert(0, "0");
                return moisPrecedent;
            }
            //cas d'une limite entre fin d'année et début d'année
            if (int.Parse(moisPrecedent) == 0){
                moisPrecedent = "12";
                return moisPrecedent;
            }
            //cas par défault
            else{
                return moisPrecedent;
            }
        }

        /*
         * surcharge de la méthode getMoisPrecedent()
         * retourne le mois précédent de la date passée en paramètre
         * 
         * **/
        public static string getMoisPrecedent(DateTime uneDate){
            //extraction du num du mois
            string unMois = (uneDate.ToString("MM/dd/yyyy")).Substring(0, 2);

            //calcul du mois précédent
            string moisPrecedent = (int.Parse(unMois) - 1).ToString(); //--->>>> OPTIMISATION??

            //vérification du format à double chiffre (ex: "01", "10"...)
            if (int.Parse(moisPrecedent) < 10 && int.Parse(moisPrecedent) != 0)
            {      
                moisPrecedent = moisPrecedent.Insert(0, "0");
                return moisPrecedent;
            }
            //cas d'une limite entre fin d'année et début d'année
            if (int.Parse(moisPrecedent) == 0)
            {
                moisPrecedent = "12";
                return moisPrecedent;
            }
            //cas par défault
            else{
                return moisPrecedent;
            }
        }


        /*
         * méthode retournant le mois suivant le mois actuel au format "MM"
         * **/
        public static string getMoisSuivant()
        {
            //recupération du mois présent dans une valeur
            string moisPresent = (DateTime.Now.ToString("MM/dd/yyyy")).Substring(0, 2);

            //calcul du mois suivant
            string moisSuivant = (int.Parse(moisPresent) + 1).ToString();

            //vérification du format à double chiffre (ex: "01", "10"...)
            if (moisSuivant.Length < 2) //peut etre faire la meme mais en int pour la coherence avec precedemment
            {      
                moisSuivant = moisSuivant.Insert(0, "0");
                return moisSuivant;
            }
            //cas d'une limite entre fin d'année et début d'année
            if (moisSuivant.Equals("13"))
            {
                moisSuivant = "01";
                return moisSuivant;
            }
            //cas par défault
            else
            {
                return moisSuivant;
            }
        }

        /*
         * surcharge de la méthode getMoisSuivant()
         * retourne le mois précédent de la date passée en paramètre
         * **/
        public static string getMoisSuivant(DateTime uneDate)
        {
            //extraction du num du mois
            string moisEntre = (uneDate.ToString("MM/dd/yyyy")).Substring(0, 2);//

            //calcul du mois suivant
            string moisSuivant = (int.Parse(moisEntre) + 1).ToString(); //--->>>> OPTIMISATION??

            //vérification du format à double chiffre (ex: "01", "10"...)
            if (moisSuivant.Length < 2)
            {      
                moisSuivant = moisSuivant.Insert(0, "0");
                return moisSuivant;
            }
            //cas d'une limite entre fin d'année et début d'année
            if (moisSuivant.Equals("13"))
            {
                moisSuivant = "01";
                return moisSuivant;
            }
            //cas par défault
            else
            {
                return moisSuivant;
            }
        }

        /*
         * méthode retournant vrai si la date actuelle 
         * se trouve entre unJour et unAutreJour passés en paramètres 
         * **/
        public static bool entre(int unJour, int unAutreJour)
        {
            //recupération du numero du jour actuel dans une valeur
            int jourPresent = int.Parse((DateTime.Now.ToString("MM/dd/yyyy")).Substring(3, 2));
            
            //test sur la position du jour actuel par rapport aux paramètres 
            //et le bon ordre des paramètres entrés
            if((jourPresent >= unJour && jourPresent <= unAutreJour) && unJour <= unAutreJour)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /*
        * Surcharge de la méthode entre()
        *  
        * retourne vrai si la date DateTime 
        * se trouve entre unJour et unAutreJour passés en paramètres 
        * **/
        public static bool entre(int unJour, int unAutreJour, DateTime uneDate)
        {
            //recupération du numero du jour de uneDate dans une valeur
            int jourDate = int.Parse((uneDate.ToString("MM/dd/yyyy")).Substring(3, 2));

            //test sur la position du jour de la date par rapport aux paramètres 
            //et le bon ordre des paramètres entrés
            if ((jourDate >= unJour && jourDate <= unAutreJour) && unJour <= unAutreJour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Clôture_des_fiches
{
    abstract public class GestionDates
    {
        /**
         * Retourne le mois précédent le mois actuel
         * 
         * @return string mois précédent au format "MM"
         */
        ///<summary>
        ///Retourne le mois précédent le mois actuel
        ///</summary>
        ///<returns>
        ///mois précédent au format string "MM"
        /// </returns>
        public static string getMoisPrecedent()
        {
            //recupération du mois présent dans une valeur
            string moisPresent = (DateTime.Now.ToString("MM/dd/yyyy"))
                                    .Substring(0, 2);

            //calcul du mois précédent
            string moisPrecedent = (int.Parse(moisPresent) - 1).ToString();
          

            //vérification du format à double chiffre (ex: "01", "10"...)
            if ((int.Parse(moisPrecedent) < 10) && (int.Parse(moisPrecedent) != 0)) {
                
                moisPrecedent = moisPrecedent.Insert(0, "0");
                return moisPrecedent;
            }
            
            //cas d'une limite entre fin d'année et début d'année
            if (int.Parse(moisPrecedent) == 0) {

                moisPrecedent = "12";
                return moisPrecedent;

            } else {
                //cas par défault
                return moisPrecedent;
            }
        }

        /**
         * Retourne le mois précédent le mois saisi
         * 
         * Surcharge de la méthode getMoisPrecedent()
         * 
         * @uneDate DateTime
         * 
         * @return string mois précédent au format "MM"
         */
        ///<summary>
        ///Retourne le mois précédent le mois saisi.
        ///Surcharge de la méthode getMoisPrecedent().
        ///</summary>
        ///<param name="uneDate">DateTime</param>
        ///<returns>
        ///mois précédent au format string "MM"
        /// </returns>
        public static string getMoisPrecedent(DateTime uneDate){
            //extraction du num du mois
            string unMois = (uneDate.ToString("MM/dd/yyyy")).Substring(0, 2);

            //calcul du mois précédent
            string moisPrecedent = (int.Parse(unMois) - 1).ToString();

            //vérification du format à double chiffre (ex: "01", "10"...)
            if ((int.Parse(moisPrecedent) < 10) && (int.Parse(moisPrecedent) != 0)) {
                
                moisPrecedent = moisPrecedent.Insert(0, "0");
                return moisPrecedent;
            }
            //cas d'une limite entre fin d'année et début d'année
            if (int.Parse(moisPrecedent) == 0) {

                moisPrecedent = "12";
                return moisPrecedent;
            } else {
                //cas par défault
                return moisPrecedent;
            }
        }


        /**
         * Retourne le mois suivant le mois actuel
         * 
         * @return string mois suivant au format "MM"
         */
        ///<summary>
        ///Retourne le mois suivant le mois actuel
        /// </summary>
        ///<returns>
        ///mois suivant au format string "MM"
        /// </returns>
        public static string getMoisSuivant()
        {
            //recupération du mois présent dans une valeur
            string moisPresent = (DateTime.Now.ToString("MM/dd/yyyy"))
                                    .Substring(0, 2);

            //calcul du mois suivant
            string moisSuivant = (int.Parse(moisPresent) + 1).ToString();

            //vérification du format à double chiffre (ex: "01", "10"...)
            if (moisSuivant.Length < 2) {
                
                moisSuivant = moisSuivant.Insert(0, "0");
                return moisSuivant;
            }
            //cas d'une limite entre fin d'année et début d'année
            if (moisSuivant.Equals("13")) {

                moisSuivant = "01";
                return moisSuivant;
            } else {
                //cas par défault
                return moisSuivant;
            }
        }

        /**
         * Retourne le mois suivant le mois saisi
         * 
         * Surcharge de la méthode getMoisSuivant()
         * 
         * @uneDate DateTime
         * 
         * @return string mois suivant au format "MM"
         */
        ///<summary>
        ///Retourne le mois suivant le mois saisi.
        ///Surcharge de la méthode getMoisSuivant().
        ///</summary>
        ///<param name="uneDate">DateTime</param>
        ///<returns>
        ///mois suivant au format string "MM"
        /// </returns>
        public static string getMoisSuivant(DateTime uneDate)
        {
            //extraction du num du mois
            string moisEntre = (uneDate.ToString("MM/dd/yyyy"))
                                .Substring(0, 2);

            //calcul du mois suivant
            string moisSuivant = (int.Parse(moisEntre) + 1).ToString();

            //vérification du format à double chiffre (ex: "01", "10"...)
            if (moisSuivant.Length < 2) {
                
                moisSuivant = moisSuivant.Insert(0, "0");
                return moisSuivant;
            }
            //cas d'une limite entre fin d'année et début d'année
            if (moisSuivant.Equals("13")) {

                moisSuivant = "01";
                return moisSuivant;
            } else {
                //cas par défault
                return moisSuivant;
            }
        }

        
        /**
        * Retourne vrai si la date actuelle se situe
        * entre deux numéros de jour passés en paramètres
        * 
        * @uneJour int
        * @unAutreJour int
        * 
        * @return bool
        */
        ///<summary>
        ///Retourne vrai si la date actuelle se situe
        /// entre deux numéros de jour passés en paramètres
        ///</summary>
        ///<param name="unJour">int</param>
        ///<param name="unAutreJour">int</param>
        ///<returns>
        ///bool
        /// </returns>
        public static bool entre(int unJour, int unAutreJour)
        {
            //recupération du numero du jour actuel dans une valeur
            int jourPresent = int.Parse((DateTime.Now.ToString("MM/dd/yyyy"))
                                        .Substring(3, 2));
            
            //test sur la position du jour actuel par rapport aux paramètres 
            //et le bon ordre des paramètres entrés
            if(((jourPresent >= unJour) && (jourPresent <= unAutreJour)) &&
                (unJour <= unAutreJour)) {

                return true;

            } else {

                return false;
            }
            
        }


        /**
        * Retourne vrai si la date saisie se situe
        * entre deux numéros de jour passés en paramètres
        * 
        * Surcharge de la méthode entre(int uneDate, int uneAutreDate)
        * 
        * @uneJour int
        * @unAutreJour int
        * @uneDate DateTime
        * 
        * @return bool
        */
        ///<summary>
        ///Retourne vrai si la date saisie se situe
        /// entre deux numéros de jour passés en paramètres.
        /// Surcharge de la méthode entre(int uneDate, int uneAutreDate).
        ///</summary>
        ///<param name="unJour">int</param>
        ///<param name="unAutreJour">int</param>
        ///<param name="uneDate">DateTime</param>
        ///<returns>
        ///bool
        /// </returns>
        public static bool entre(int unJour, int unAutreJour,
                                 DateTime uneDate)
        {
            //recupération du numero du jour de uneDate dans une valeur
            int jourDate = int.Parse((uneDate.ToString("MM/dd/yyyy"))
                                     .Substring(3, 2));

            //test sur la position du jour de la date par rapport aux paramètres 
            //et le bon ordre des paramètres entrés
            if (((jourDate >= unJour) && (jourDate <= unAutreJour)) &&
                (unJour <= unAutreJour)) {

                return true;

            } else {

                return false;
            }
        }
    }
}

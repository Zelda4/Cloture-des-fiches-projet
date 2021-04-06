using MySql.Data.MySqlClient;
using System;

namespace Clôture_des_fiches
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Programme de gestion de mise à jour automatique des fiches de frais
             *  pour l'organisation GSB
             *  
             *  auteur: K. Breste
             * 
             **/
            
            //création d'un acces à la base de données
            AccesDB accesDB = new AccesDB();

            //si la date actuelle se situe entre le 1 et le 10 du mois les fiches du mois précédent son cloturées (CL)
            if (GestionDates.entre(1, 10))
            {
                accesDB.requete("UPDATE fichefrais SET idetat = 'CL' WHERE mois LIKE '%" + GestionDates.getMoisPrecedent()+"'");
            }

            //si la date actuelle se situe entre le 20 et le 31 du mois, les fiches validées (VA) du mois précédent sont mises à l'état remboursées (RB)
            if(GestionDates.entre(20, 31))//mois comptables? verifier sur cahier des charges
            {
                accesDB.requete("UPDATE fichefrais SET idetat = 'RB' WHERE idetat = 'VA' AND mois LIKE '%" + GestionDates.getMoisPrecedent() + "'");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using MySql;
using MySql.Data.MySqlClient;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Text.Unicode;

namespace Clôture_des_fiches
{
    class AccesDB
    {
        //déclarations
        MySqlConnection connexion;
        
        /**
         * Constructeur
         * 
         * Création d'une nouvelle connection
         */
         ///<summary>
         ///Constructeur de la classe AccesDB
         ///Crée une nouvelle connexion
         /// </summary>
        public AccesDB()
        {
            try {
                string connexionString = "server=localhost;user=root;" +
                    "                       database=gsb_frais;port=3306;" +
                    "                       charset=utf8";
                connexion = new MySqlConnection(connexionString);
                connexion.Open();

            } catch {

            }
            //ajouter un try catch ^
        }

        /**
         * Exécute une requete d'administration
         * sur la base de données
         * 
         * @requete string requête SQL à saisir
         */
         ///<summary>
         ///Exécute une requete d'administration
         /// sur la base de données
         ///</summary>
         ///<param name="requete">string</param>
        public void requete(string requete)
        {
            //MySqlCommand cmd = new MySqlCommand(requete, connexion);
            MySqlCommand cmd = connexion.CreateCommand();
            //cmd.ExecuteNonQuery();
            cmd.CommandText = requete;
            cmd.ExecuteNonQuery();
        }

        /**
         * Exécute une requete de séléction
         * sur la base de données
         * 
         * @selection string requête SQL de sélection à saisir  
         */
        ///<summary>
        ///Exécute une requete de séléction
        /// sur la base de données
        ///</summary>
        ///<param name="selection">string</param>
        public void selection(string selection)
        {
            MySqlCommand cmd = new MySqlCommand(selection, connexion);
            MySqlDataReader curseur = cmd.ExecuteReader();
            
            curseur.Close();
            connexion.Close();
        }
    }
}

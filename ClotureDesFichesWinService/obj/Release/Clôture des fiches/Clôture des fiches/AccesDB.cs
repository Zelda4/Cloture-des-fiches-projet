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
        
        /*
         * Constructeur
         * création d'une nouvelle connection
         */
        public AccesDB(){
            try
            {
                string connexionString = "server=localhost;user=root;database=gsb_frais;port=3306;charset=utf8";
                connexion = new MySqlConnection(connexionString);
                connexion.Open();
            }
            catch { }
            //ajouter un try catch ^
        }

        /*
         * méthode d'execution d'une requete d'administration
         * **/
        public void requete(string requete){
            //MySqlCommand cmd = new MySqlCommand(requete, connexion);
            MySqlCommand cmd = connexion.CreateCommand();
            //cmd.ExecuteNonQuery();
            cmd.CommandText = requete;
            cmd.ExecuteNonQuery();
        }
        
        /*
         * méthode d'execution d'une requete de séléction
         * **/
         public void selection(string selection){
            //declaration du curseur
            //Cursor curseur;
            //initialisation du curseur
            //curseur.init(selection);
            //ouverture du curseur
            //curseur.open();
            
            MySqlCommand cmd = new MySqlCommand(selection, connexion);
            MySqlDataReader curseur = cmd.ExecuteReader();
            
            curseur.Close();
            connexion.Close();
            
            
        }
    }
}

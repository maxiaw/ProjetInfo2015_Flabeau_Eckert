<<<<<<< HEAD
﻿using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Xml;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class Program
    {
        // Affichage du menu principal de l'application
        public static void MenuPrincipal()
        {
            List<string> ChoixMenu = new List<string>();        // Différentes possibilités offertes par le menu

            ChoixMenu.Add("     Gérer les réservations");
            ChoixMenu.Add("     Gérer le restaurant");
            ChoixMenu.Add("     Visualiser les prévisions");
            ChoixMenu.Add("     Quitter l'application");

            ConsoleKeyInfo deplaceCurseur;                    // Décrit la touche de console sur laquelle le gérant du retaurant appuie
            int compteur = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\n\n\n              ");
            Console.WriteLine("              APPLICATION DE GESTION DE RESERVATIONS POUR RESTAURANT \n\n");
            Console.WriteLine("                                      ~  *  ~");
            deplaceCurseur = Console.ReadKey();                // Obtient le caractère suivant ou la touche de fonction sur laquelle le gérant a appuyé


            do
            {
                int i = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n                                MENU PRINCIPAL");
                Console.WriteLine("\n                                    ~ * ~   \n\n");
                Console.ForegroundColor = ConsoleColor.White;


                while (i < ChoixMenu.Count)
                {

                    if (compteur == i)     // si sélectionné par le gérant : changement de couleur pour que le gérant se situe dans le menu
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n                        {0} \n", ChoixMenu[i]);
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else              // si non sélectionné par l'utilisateur
                    { 
                        Console.WriteLine(string.Format("\n         {0} \n", ChoixMenu[i])); 
                    }
                    i++;
                }
                deplaceCurseur = Console.ReadKey();

                if ((deplaceCurseur.Key == ConsoleKey.UpArrow) && compteur > 0)
                { compteur--; }    // Diminution du curseur lorsque l'on descend avec la touche du clavier

                if ((deplaceCurseur.Key == ConsoleKey.DownArrow) && compteur < ChoixMenu.Count - 1)
                { compteur++; }    // Augmentation du curseur lorsque l'on monte avec la touche du clavier
            }
            while (deplaceCurseur.Key != ConsoleKey.Enter);// Tant que le gérant n'a rien sélectionné


            if (compteur == 0)
            {
                Console.Clear();
                //Code à ajouter
            }

            if (compteur == 1)
            {
                Console.Clear();
                //Code à ajouter                
            }

            if (compteur == 2)
            {
                Console.Clear();
                //Code à ajouter               
            }

            if (compteur == 3) // Sortie de l'application
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n\n\n\n\n\t");
                Console.WriteLine("\t               Merci d'avoir utilisé l'application\n");
                Console.WriteLine("\t                  Maxime Eckert & Alice Flabeau\n");
                Console.WriteLine("\t                              ~ * ~");
            }

        }

		public static void Main (string[] args)
		{
			
			Console.WriteLine ("TEST");
			Restaurant RestoTest = new Restaurant ();
			FormuleAEmporter Nouilles = new FormuleAEmporter ();
			FormuleAuBar tequila = new FormuleAuBar ();

			RestoTest.AjouterFormule (Nouilles);
			RestoTest.AjouterFormule (tequila);
			RestoTest.SauvegarderFormules();
			Console.ReadLine ();
		}
	}
}
=======
﻿using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class Program
    {
        Restaurant restaurant = new Restaurant();

        // Affichage du menu principal de l'application
        public static void MenuPrincipal()
        {
            List<string> ChoixMenu = new List<string>();        // Différentes possibilités offertes par le menu

            ChoixMenu.Add("     Gérer les réservations");
            ChoixMenu.Add("     Gérer le restaurant");
            ChoixMenu.Add("     Visualiser les prévisions");
            ChoixMenu.Add("     Quitter l'application");

            ConsoleKeyInfo deplaceCurseur;                    // Décrit la touche de console sur laquelle le gérant du retaurant appuie
            int compteur = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\n\n\n\n\n              ");
            Console.WriteLine("              APPLICATION DE GESTION DE RESERVATIONS POUR RESTAURANT \n\n");
            Console.WriteLine("                                      ~  *  ~");
            deplaceCurseur = Console.ReadKey();                // Obtient le caractère suivant ou la touche de fonction sur laquelle le gérant a appuyé


            do
            {
                int i = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n                                MENU PRINCIPAL");
                Console.WriteLine("\n                                    ~ * ~   \n\n");
                Console.ForegroundColor = ConsoleColor.White;


                while (i < ChoixMenu.Count)
                {

                    if (compteur == i)     // si sélectionné par le gérant : changement de couleur pour que le gérant se situe dans le menu
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n                        {0} \n", ChoixMenu[i]);
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else              // si non sélectionné par l'utilisateur
                    {
                        Console.WriteLine(string.Format("\n         {0} \n", ChoixMenu[i]));
                    }
                    i++;
                }
                deplaceCurseur = Console.ReadKey();

                if ((deplaceCurseur.Key == ConsoleKey.UpArrow) && compteur > 0)
                { compteur--; }    // Diminution du compteur

                if ((deplaceCurseur.Key == ConsoleKey.DownArrow) && compteur < ChoixMenu.Count - 1)
                { compteur++; }    // Augmentation du compteur
            }
            while (deplaceCurseur.Key != ConsoleKey.Enter);// Tant que le gérant n'a rien sélectionné


            if (compteur == 0)
            {
                Console.Clear();
                //Code à ajouter
            }

            if (compteur == 1)
            {
                Console.Clear();
                GererLeRestaurant();
            }

            if (compteur == 2)
            {
                Console.Clear();
                //Code à ajouter               
            }

            if (compteur == 3) // Sortie de l'application
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n\n\n\n\n\t");
                Console.WriteLine("\t               Merci d'avoir utilisé l'application\n");
                Console.WriteLine("\t                  Maxime Eckert & Alice Flabeau\n");
                Console.WriteLine("\t                              ~ * ~");
            }
        }

        
        //Affichage du sous-menu : Gérer le retaurant
        public static void GererLeRestaurant()
        {
            List<string> ChoixMenu1 = new List<string>();        

            ChoixMenu1.Add("     Ajouter une table au restaurant");
            ChoixMenu1.Add("     Afficher la liste des tables");
            ChoixMenu1.Add("     Retirer une table du restaurant");
            ChoixMenu1.Add("     Afficher la liste des formules");
            ChoixMenu1.Add("     Engager un cuisiner");
            ChoixMenu1.Add("     Renvoyer un cuisinier");
            ChoixMenu1.Add("     Retour au menu prinicpal");

            ConsoleKeyInfo deplaceCurseur;                    
            int compteur = 0;          

            do
            {
                int i = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n                                GERER LE RESTAURANT");
                Console.WriteLine("\n                                    ~ * ~   \n\n");
                Console.ForegroundColor = ConsoleColor.White;


                while (i < ChoixMenu1.Count)
                {

                    if (compteur == i)    
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n                        {0} \n", ChoixMenu1[i]);
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else             
                    {
                        Console.WriteLine(string.Format("\n         {0} \n", ChoixMenu1[i]));
                    }
                    i++;
                }
                deplaceCurseur = Console.ReadKey();

                if ((deplaceCurseur.Key == ConsoleKey.UpArrow) && compteur > 0)
                { compteur--; }    

                if ((deplaceCurseur.Key == ConsoleKey.DownArrow) && compteur < ChoixMenu1.Count - 1)
                { compteur++; }    
            }
            while (deplaceCurseur.Key != ConsoleKey.Enter);// Tant que le gérant n'a rien sélectionné


            if (compteur == 0)
            {
                Console.Clear();
                restaurant.AjouterTable();
            }

            if (compteur == 1)
            {
                Console.Clear();
                restaurant.AfficherLesTables();
            }

            if (compteur == 2)
            {
                Console.Clear();
                //Choisir le numéro de la table que l'on veut supprimer
            }

            if (compteur == 3)
            {
                Console.Clear();
                restaurant.AfficherLesFormules();              
            }

            if (compteur == 4)
            {
                Console.Clear();
                restaurant.EngagerCuisinier();              
            }

            if (compteur == 5)
            {
                Console.Clear();
                restaurant.RenvoyerCuisinier();              
            }
            
            if (compteur == 6) // Retour au menu principal
            {
                Console.Clear();
                MenuPrincipal();
            }
        }

        //**************************************************
        //****************** MAIN **************************
        //**************************************************

		public static void Main (string[] args)
		{
            MenuPrincipal();
            //FormuleRapide F = new FormuleRapide ();

            Console.ReadLine();
		}
	}
}
>>>>>>> origin/master

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class Restaurant
    {
        public string NomRestaurant { get; protected set; }
        public List <Reservation> ListeReservations { get; protected set; }
        public int NombreTables { get; protected set; }
        public List<Table> ListeTables { get; protected set; }
        public List<Formule> ListeFormules { get; protected set; }
        public int NombreCuisiniers { get; protected set; }
        public int HeureFinDeService { get; protected set; }
        public int MinutesFinDeService { get; protected set; }

        public Restaurant ()
        {
            NomRestaurant = "Chez Maxime & Alice";
            ListeReservations = new List<Reservation>();
            NombreTables = 10;
            ListeTables = new List<Table>();
            ListeFormules = new List<Formule>();
            NombreCuisiniers = 2;
            HeureFinDeService = 23;
            MinutesFinDeService = 0; 
        }

        public Restaurant (string nom, int nbTables, int nbCuisiniers, int H, int m)
        {
            NomRestaurant = nom;
            ListeReservations = new List<Reservation>();
            NombreTables = nbTables;
            ListeTables = new List<Table>();
            ListeFormules = new List<Formule>();
            NombreCuisiniers = nbCuisiniers;
            HeureFinDeService = H;
            MinutesFinDeService = m;           
        }

        public void AjouterTable()
        {
            int typeTable = 0;
            do
            {
                Console.WriteLine("De quel type de table s'agit-il ?");
                Console.WriteLine("\t Bar [1]");
                Console.WriteLine("\t Table ronde [2]");
                Console.WriteLine("\t Table rectangulaire [3]");
                Console.WriteLine("\t Table carrée [4]");
                typeTable = int.Parse(Console.ReadLine());
            }
            while ((typeTable < 1) || (typeTable > 4));

            int Largeur = 0;
            int Longueur = 0;
            int NbMax = 0;


            if (typeTable == 1)
            {
                Console.WriteLine("Combien de places y a t-il sur la longueur du bar ?");
                Longueur = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Combien de places y a t-il sur la largeur du bar ?");
                    Largeur = int.Parse(Console.ReadLine());
                }
                while (Largeur >= Longueur);

                Bar TableBar = new Bar(Largeur, Longueur, 0);
                ListeTables.Add(TableBar);
            }
            if (typeTable == 2)
            {
                do
                {
                Console.WriteLine("Combien de personnes cette table ronde peut-elle accueillir au maximum?");
                NbMax = int.Parse(Console.ReadLine());
                }
                while (NbMax < 1);

                TableRonde TableRonde = new TableRonde(NbMax, 0);
                ListeTables.Add(TableRonde);
            }
            if (typeTable == 3)
            {
                Console.WriteLine("Combien de places y a t-il sur la longueur ?");
                Longueur = int.Parse(Console.ReadLine());
                do
                {
                    Console.WriteLine("Combien de places y a t-il sur la largeur ?");
                    Largeur = int.Parse(Console.ReadLine());
                }
                while (Largeur >= Longueur);

                Console.WriteLine("Cette table est-elle jumelable ? (Tapez O pour Oui, N pour Non)");
                char Jumelage = char.Parse(Console.ReadLine().ToUpper());
                
                if (Jumelage == 'O')
                {
                    TableRectangulaireJumelable TableRectangulaireJ = new TableRectangulaireJumelable(Largeur, Longueur, 0);
                    ListeTables.Add(TableRectangulaireJ);
                }
                else
                {
                    TableRectangulaire TableRectangulaire = new TableRectangulaire(Largeur, Longueur, 0);
                    ListeTables.Add(TableRectangulaire);
                }
            }
            if (typeTable == 4)
            {
                Console.WriteLine("Combien de places y a t-il sur chaque côté de la table ?");
                Largeur = int.Parse(Console.ReadLine());

                Console.WriteLine("Cette table est-elle jumelable ? (Tapez O pour Oui, N pour Non)");
                char Jumelage = char.Parse(Console.ReadLine().ToUpper());

                if (Jumelage == 'O')
                {
                    TableCarreeJumelable TableCarreeJ = new TableCarreeJumelable(Largeur, 0);
                    ListeTables.Add(TableCarreeJ);
                }
                else
                {
                    TableCarree TableCarree = new TableCarree(Largeur, 0);
                    ListeTables.Add(TableCarree);
                }
            }   
        }

        public void SupprimerTable(Table T)
        {
            ListeTables.Remove(T);
        }

        public void AjouterFormule(Formule F)
        {
            ListeFormules.Add(F);
        }
        public void SupprimerFormule(Formule F)
        {
            ListeFormules.Remove(F);
        }

        public void AjouterReservation(Reservation R)
        {
            ListeReservations.Add(R);
        }
        public void AnnulerRéservation(Reservation R)
        {
            ListeReservations.Remove(R);
        }

        public void EngagerCuisinier() //Permert d'engager un cuisinier supplémentaire 
        {
            NombreCuisiniers++;
            Console.WriteLine("Il y a désormais {0} cuisiniers travaillant au restaurant.", NombreCuisiniers);
        }
        public void RenvoyerCuisinier() //Permet de virer un cuisinier
        {
            if (NombreCuisiniers > 1)
            {
                NombreCuisiniers--;
                Console.WriteLine("Il y a désormais {0} cuisiniers travaillant au restaurant.", NombreCuisiniers);
            }
            else
            {
                Console.WriteLine("Vous ne pouvez pas renvoyer de cuisinier, il n'y en aura plus aucun.");
            }
        }

        public void AfficherLesTables()
        {
            Console.WriteLine("Liste des tables existantes dans le restaurant:");

            foreach (Table table in ListeTables)
            {
                Console.WriteLine("===========================================\n===========================================");
                Console.WriteLine(table.ToString());
                Console.WriteLine("===========================================\n===========================================");
            }
        }

		public void AfficherLesFormules()
		{
			Console.WriteLine ("Liste des formules existantes dans le restaurant:");

			foreach (Formule formule in ListeFormules) 
			{
				Console.WriteLine ("===========================================\n===========================================");
				Console.WriteLine (formule.ToString());
				Console.WriteLine ("===========================================\n===========================================");
			}
		}

		public void AfficherListeReservations()
		{
			Console.WriteLine ("Voici la liste des réservations à venir de " + NomRestaurant + " : ");
			foreach (Reservation Resa in ListeReservations) 
			{
				Console.WriteLine ("===========================================\n===========================================");
				Console.WriteLine (Resa.ToString());
				Console.WriteLine ("===========================================\n===========================================");
			}
		}
    }
}



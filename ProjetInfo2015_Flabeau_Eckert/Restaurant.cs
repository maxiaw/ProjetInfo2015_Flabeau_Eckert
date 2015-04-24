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

        public void AjouterTable(Table T)
        {
            ListeTables.Add(T);
        }
        public void SupprimerTable(Table T)
        {
            ListeTables.Remove(T);
        }

        public void AjouterFormule(Formule F)
        {
            ListeFormules.Add(F);
        }
        public void SupprimerTable(Formule F)
        {
            ListeFormules.Remove(F);
        }

        public void AjouterReservation(Reservation R)
        {
            ListeReservations.Add(R);
        }
        public void SupprimerTable(Reservation R)
        {
            ListeReservations.Remove(R);
        }
    }
}



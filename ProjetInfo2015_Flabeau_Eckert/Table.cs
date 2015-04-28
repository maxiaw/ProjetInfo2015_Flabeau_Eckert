using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    abstract class Table
    {
        public static int CompteurTables = 0;
        public int NumeroTable { get; protected set; }
        public int NombrePlacesMax { get; protected set; }
        public int NombrePlacesOccupees { get; protected set; }
		public bool EstJumelee { get; protected set; }
        public DateTime[,] TableauHoraires { get; protected set; }
        public int Largeur { get; protected set; }
        public int Longueur { get; protected set; }

        public Table()
        {
            CompteurTables = CompteurTables + 1;
            NumeroTable = CompteurTables;
            NombrePlacesMax = 4;
            NombrePlacesOccupees = 0;
            EstJumelee = false;
            TableauHoraires = new DateTime[2, 100];
            Longueur = 1;
            Largeur = Longueur; //Table carrée par défaut
        }
		public override string ToString ()
		{
			string ch = "Table n°"+ this.NumeroTable + " \n " + " Nombre de places maximal : " + this.NombrePlacesMax + " \n " + " Nombre de place occupées : " + this.NombrePlacesOccupees + " \n " + " Situation (est-elle jumelée?) : " + EstJumelee + " \n " + " Largeur : " + Largeur + " m " + " \n " + " Longueur : " + Longueur + " m ";
			return ch;
		}
    }
}



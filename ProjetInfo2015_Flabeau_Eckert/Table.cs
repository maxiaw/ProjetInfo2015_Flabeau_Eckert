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
		public bool EstJumelee { get; set; }
        public DateTime[,] TableauHoraires { get; protected set; }
        public Table [] TableauTablesJumelees { get; protected set; } //Tableau contenant les 2 tables d'origine si la table est le résultat d'un jumelage
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
            TableauTablesJumelees = new Table[2]; //Tableau contenant les 2 tables d'origine pour un jumelage
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



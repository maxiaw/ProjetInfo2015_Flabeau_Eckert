using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            TableauHoraires = new DateTime[100, 2];
            Longueur = 1;
            Largeur = Longueur; //Table carrée par défaut
        }
    }
}


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

        public Table()
        {
            CompteurTables = CompteurTables + 1;
            NumeroTable = CompteurTables;
            NombrePlacesMax = 4;
            NombrePlacesOccupees = 0;
            EstJumelee = false;
            TableauHoraires = new DateTime[100, 2];
        }
    }
}



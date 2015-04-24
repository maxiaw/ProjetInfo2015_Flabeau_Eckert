using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class Bar : Table
    {
        public Bar()
            : base()
        {
            Largeur = 1;
            Longueur = 5;
        }

        public Bar(int l, int Lo, int nbMax, int nbOccupees)
            : base()
        {
            Largeur = l;
            Longueur = Lo;
            NombrePlacesMax = nbMax;
            NombrePlacesOccupees = nbOccupees;
        }
    }
}




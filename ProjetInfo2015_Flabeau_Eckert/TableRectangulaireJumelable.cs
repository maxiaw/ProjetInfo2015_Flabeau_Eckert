using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class TableRectangulaireJumelable : Table, IJumelable
    {
        public int Largeur { get; protected set; }
        public int Longueur { get; protected set; }

        public TableRectangulaireJumelable () : base ()
        {
            Largeur = 2;
            Longueur = 3;
        }

         public TableRectangulaireJumelable (int l, int Lo, int nbOccupees) : base()
         {
             Largeur = l;
             Longueur = Lo;
             NombrePlacesMax = 2*l + 2*Lo;
             NombrePlacesOccupees = nbOccupees;
         }
    }
}

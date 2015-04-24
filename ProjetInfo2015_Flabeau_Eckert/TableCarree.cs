using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
     class TableCarree : Table
    {
        public int Largeur { get; protected set; }

        public TableCarree () : base ()
        {
            Largeur = 2;
        }

         public TableCarree (int l, int nbOccupees) : base()
         {
             Largeur = l;
             NombrePlacesMax = 4 * l;
             NombrePlacesOccupees = nbOccupees;
         }
    }
}

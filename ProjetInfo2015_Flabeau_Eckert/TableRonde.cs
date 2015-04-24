using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class TableRonde : Table
    {
        public TableRonde () : base ()
        {
        }

         public TableRonde (int nbMax, int nbOccupees) : base()
         {
             NombrePlacesMax = nbMax;
             NombrePlacesOccupees = nbOccupees;
         }
    }
}

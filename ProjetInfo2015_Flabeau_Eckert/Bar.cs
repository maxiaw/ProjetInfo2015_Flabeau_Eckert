using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class Bar : Table
    {
        public Bar () : base ()
        {
        }

         public Bar (int nbMax, int nbOccupees) : base()
         {
             NombrePlacesMax = nbMax;
             NombrePlacesOccupees = nbOccupees;
         }
    }
}

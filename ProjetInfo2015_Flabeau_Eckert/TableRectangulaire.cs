﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class TableRectangulaire : Table
    {
        public TableRectangulaire(): base()
        {
            Largeur = 1;
            Longueur = 3;
        }

        public TableRectangulaire(int l, int Lo, int nbOccupees): base()
        {
            Largeur = l;
            Longueur = Lo;
            NombrePlacesMax = 2 * l + 2 * Lo;
            NombrePlacesOccupees = nbOccupees;
        }
    }
}



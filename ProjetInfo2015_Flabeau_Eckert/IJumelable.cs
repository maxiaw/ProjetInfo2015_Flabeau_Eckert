using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    interface IJumelable
    {
        Table Jumeler(Table T); //On jumèle la table jumelable à a table T, ce qui renvoit une nouvelle table
        Table Separer(Table T); //On sépare la table de la table T, ce qui renvoit la table T 
    }
}

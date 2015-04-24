using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class TableCarreeJumelable : Table, IJumelable
    {
        public int Largeur { get; protected set; }
              
        public TableCarreeJumelable () : base ()
        {
            Largeur = 2;
        }

         public TableCarreeJumelable (int l, int nbOccupees) : base ()
         {
             Largeur = l;
             NombrePlacesMax = 4 * l;
             NombrePlacesOccupees = nbOccupees;
         }

         public Table Jumeler(Table T)
         {
             if (T is TableCarreeJumelable) 
             {
                T=((TableCarreeJumelable) T); //Conversion de T en TableCarreeJumelable
                if ((this.EstJumelee == false) && (T.EstJumelee == false)) //Elles ne doivent pas être déjà jumelées à d'autres tables
                {
                    if (T.Largeur == this.Largeur) //Compatibilité des tables
                    {
                        TableRectangulaire NouvelleTable = new TableRectangulaire(this.Largeur, T.Largeur + this.Largeur, T.NombrePlacesOccupees + this.NombrePlacesOccupees);
                    }
                }
                return NouvelleTable;
             }
             else if (T is TableRectangulaireJumelable)
             {
                 T = ((TableRectangulaireJumelable)T); //Conversion de T en TableRectangulaireJumelable
                 if ((this.EstJumelee == false) && (T.EstJumelee == false)) //Elles ne doivent pas être déjà jumelées à d'autres tables
                 {
                     if (T.Largeur == this.Largeur) //Compatibilité des tables
                     {
                         TableRectangulaire NouvelleTable = new TableRectangulaire(this.Largeur, T.Longueur + this.Longueur, T.NombrePlacesOccupees + this.NombrePlacesOccupees);
                     }
                 }
                 return NouvelleTable;
             }
             
         }
    }
}

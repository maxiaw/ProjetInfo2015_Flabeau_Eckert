/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class TableRectangulaireJumelable : Table, IJumelable
    {
        public TableRectangulaireJumelable()
            : base()
        {
            Largeur = 1;
            Longueur = 3;
        }

        public TableRectangulaireJumelable(int l, int Lo, int nbOccupees)
            : base()
        {
            Largeur = l;
            Longueur = Lo;
            NombrePlacesMax = 2 * l + 2 * Lo;
            NombrePlacesOccupees = nbOccupees;
        }

        public Table Jumeler(Table T)
        {
            if (T is TableCarreeJumelable)
            {
                T = ((TableCarreeJumelable)T); //Conversion de T en TableCarreeJumelable
                if ((this.EstJumelee == false) && (T.EstJumelee == false)) //Elles ne doivent pas être déjà jumelées à d'autres tables
                {
                    if (T.Largeur == this.Largeur) //Compatibilité des tables
                    {
                        TableRectangulaire NouvelleTable = new TableRectangulaire(this.Largeur, T.Largeur + this.Longueur, T.NombrePlacesOccupees + this.NombrePlacesOccupees);
                        this.EstJumelee = true;
                        T.EstJumelee = true; //Les deux tables deviennent jumelées
                        return NouvelleTable;
                    }
                }
            }
            else if (T is TableRectangulaireJumelable)
            {
                T = ((TableRectangulaireJumelable)T); //Conversion de T en TableRectangulaireJumelable
                if ((this.EstJumelee == false) && (T.EstJumelee == false)) //Elles ne doivent pas être déjà jumelées à d'autres tables
                {
                    if (T.Largeur == this.Largeur) //Compatibilité des tables
                    {
                        TableRectangulaire NouvelleTable = new TableRectangulaire(this.Largeur, T.Longueur + this.Longueur, T.NombrePlacesOccupees + this.NombrePlacesOccupees);
                        this.EstJumelee = true; //Les deux tables deviennent jumelées
                        T.EstJumelee = true;
                        return NouvelleTable;
                    }
                }
            }
        }

        public Table Separer(Table T)
        {

        }
    }
}*/




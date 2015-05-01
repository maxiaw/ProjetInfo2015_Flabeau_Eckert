using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class TableCarreeJumelable : Table, IJumelable
    {
        public TableCarreeJumelable() : base()
        {
            Largeur = 2;
            Longueur = Largeur;
        }

        public TableCarreeJumelable(int l, int nbOccupees) : base()
        {
            Largeur = l;
            Longueur = Largeur;
            NombrePlacesMax = 4 * l;
            NombrePlacesOccupees = nbOccupees;
        }

        public Table Jumeler(Table T) //Jumèle la table avec la table T
        {
            if (T is TableCarreeJumelable)
            {
                T = ((TableCarreeJumelable)T); //Conversion de T en TableCarreeJumelable
                if ((this.EstJumelee == false) && (T.EstJumelee == false)) //Elles ne doivent pas être déjà jumelées à d'autres tables
                {
                    if (T.Largeur == this.Largeur) //Compatibilité des tables
                    {
                        TableRectangulaire NouvelleTable = new TableRectangulaire(this.Largeur, T.Largeur + this.Largeur, 0);
                        this.EstJumelee = true;
                        T.EstJumelee = true; //Les deux tables deviennent jumelées
                        NouvelleTable.TableauTablesJumelees[0] = this;
                        NouvelleTable.TableauTablesJumelees[1] = T;
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
                        TableRectangulaire NouvelleTable = new TableRectangulaire(this.Largeur, T.Longueur + this.Largeur, 0);
                        this.EstJumelee = true; //Les deux tables deviennent jumelées
                        T.EstJumelee = true;
                        NouvelleTable.TableauTablesJumelees[0] = this;
                        NouvelleTable.TableauTablesJumelees[1] = T;
                        return NouvelleTable;
                    }
                }
            }
            else
            {
                Console.WriteLine("Ces tables ne sont pas jumelables.");
                return T;
            }
        }

        public Table Separer(Table T) //Sépare la table de la table T
        {

        }
    }
}




using System;

namespace ProjetInfo2015_Flabeau_Eckert
{
	 class Reservation
	{
		public int CompteurReservation = 0;
        public int NumeroReservation { get; protected set; }
        public int NumeroTableAttribue { get; protected set; }
        public Client ClientReservateur { get; protected set; }
        public Formule FormuleChoisie { get; protected set; }
        public DateTime DateReservation { get; protected set; }
        public int NombreConvives { get; protected set; }

		public Reservation (Client clientReservateur, Formule formuleChoisie, DateTime date, int nbConvives)
		{
			ClientReservateur = clientReservateur;
			FormuleChoisie = formuleChoisie;
			DateReservation = date;
			NombreConvives = nbConvives;
			CompteurReservation++;
			NumeroReservation += CompteurReservation;
		}
		public void AttribuerTable(Table T)
		{
            int i=0;
            while (i < T.TableauHoraires.Length)
            {
                if (T.TableauHoraires[0, i] == null) //On remplit la première case non nulle
                {
                    T.TableauHoraires[0, i] = DateReservation;
                    T.TableauHoraires[1, i] = DateReservation + FormuleChoisie.TempsDePreparation + FormuleChoisie.EstimationTempsPresence;
                }
                i++;
            }
            NumeroTableAttribue = T.NumeroTable; 
		}
		public void ModifierRerservation()
		{
			
		}
		public override string ToString ()
		{
			string ch = "Réservation n°"+NumeroReservation+"\n"+"Client : "+ this.ClientReservateur.Nom + " \n " + "Formule choisie : "+ this.FormuleChoisie.NomFormule + " \n " + " Date : " + DateReservation + " \n " + " Nombre de personnes : " + this.NombreConvives;// A gérer quand le tableau sera implémenté
			return ch;
		}
	}
}


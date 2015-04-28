using System;

namespace ProjetInfo2015_Flabeau_Eckert
{
	 class Reservation
	{
		private int CompteurReservation = 0;
		private int NumeroReservation{ get;set;}
        Client ClientReservateur { get; set; }
        Formule FormuleChoisie { get; set; }
        private DateTime dateTime { get; set; }
		private int NombreConvives{ get; set;}

		public Reservation (Client clientReservateur, Formule formuleChoisie, DateTime date,int nbConvives)
		{
			ClientReservateur = clientReservateur;
			FormuleChoisie = formuleChoisie;
			dateTime = date;
			NombreConvives = nbConvives;
			CompteurReservation++;
			NumeroReservation += CompteurReservation;
		}
		public void AttribuerTable(DateTime D)
		{
			
		}
		public void ModifierRerservation(DateTime D)
		{
			AttribuerTable (D);
		}
		public override string ToString ()
		{
			string ch = "Réservation n°"+this.NumeroReservation+"\n"+"Client: "+ this.ClientReservateur + " \n " + " Formule choisie : "+ this.FormuleChoisie + " \n " + " Date : " + this.dateTime + " \n " + " Nombre de personnes : " + this.NombreConvives;// A gérer quand le tableau sera implémenté
			return ch;
		}
	}
}


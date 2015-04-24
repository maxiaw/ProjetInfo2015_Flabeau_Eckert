using System;

namespace ProjetInfo2015_Flabeau_Eckert
{
	 class Reservation
	{
		private int CompteurReservation = 0;
		private int NumeroReservation{ get;set;}
		Client ClientReservateur=new Client();
		Formule FormuleChoisie=new Formule();
		private DateTime dateTime=new DateTime();
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
			//tableauHoraire[i,j]=D;
		}
		public void ModifierRerservation(DateTime D)
		{
			AttribuerTable (D);// Ajoutons nous un client à l'affectation de la table et de l'horaire?
		}
		public override string ToString ()
		{
			string ch = "";// A gérer quand le tableau sera implémenté
			return ch;
		}
	}
}


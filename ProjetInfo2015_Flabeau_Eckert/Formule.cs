using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    abstract class Formule
    {
		protected int TempsDePreparation{ get; set;}
		protected int EstimationTempsPresence{ get; set;}
		public Formule()
		{
		}
		public override string ToString ()
		{
			string ch = "Formule: "+ Formule + " \n " + "Temps de préparation: " + TempsDePreparation + " min\n " + " Estimation de présence du client: " + EstimationTempsPresence + " min";
			return ch;
		}
    }
}

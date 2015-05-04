using System;

namespace ProjetInfo2015_Flabeau_Eckert
{
	class FormuleRapide:Formule
	{
		public FormuleRapide () : base ()
		{
			NomFormule = "FormuleRapide";

			TempsDePreparation = 10;
			EstimationTempsPresence = 20;
		}
	}
}


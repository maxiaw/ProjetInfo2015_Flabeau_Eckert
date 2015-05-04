using System;

namespace ProjetInfo2015_Flabeau_Eckert
{
	class FormuleGastronomique:Formule
	{
		public FormuleGastronomique () : base ()
		{
			NomFormule = "FormuleGastronomique";
	
			TempsDePreparation = 60;
			EstimationTempsPresence = 120;
		}
	}
}


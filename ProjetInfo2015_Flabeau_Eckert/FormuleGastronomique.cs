using System;

namespace ProjetInfo2015_Flabeau_Eckert
{
	class FormuleGastronomique:Formule
	{
		public FormuleGastronomique () : base ()
		{
			TempsDePreparation = 60;
			EstimationTempsPresence = 120;
		}
	}
}


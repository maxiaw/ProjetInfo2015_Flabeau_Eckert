using System;

namespace ProjetInfo2015_Flabeau_Eckert
{
	class FormuleNormale:Formule
	{
		public FormuleNormale () : base ()
		{
			NomFormule = "FormuleNormale";


			TempsDePreparation = 15;
			EstimationTempsPresence = 30;
		}
	}
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetInfo2015_Flabeau_Eckert
{
    class FormuleAEmporter : Formule
    {
        public FormuleAEmporter() : base ()
        {
            NomFormule = "FormuleAEmporter";
            TempsDePreparation = 10;
            EstimationTempsPresence = 10;
        }
    }
}

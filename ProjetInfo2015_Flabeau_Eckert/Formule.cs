using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ProjetInfo2015_Flabeau_Eckert
{
    abstract class Formule
    {
        protected string NomFormule { get; set; }
		protected int TempsDePreparation{ get; set;}
		protected int EstimationTempsPresence{ get; set;}
		
        public Formule() 
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Formule");
            xmlDoc.AppendChild(rootNode);

            XmlNode TempsDePrepa = xmlDoc.CreateElement("TempsDePreparation");
            TempsDePrepa.InnerText = TempsDePreparation.ToString();
            rootNode.AppendChild(TempsDePrepa);
            XmlNode TempsPresence = xmlDoc.CreateElement("TempsDePreparation");
            TempsPresence.InnerText = EstimationTempsPresence.ToString();
            rootNode.AppendChild(TempsPresence);

            xmlDoc.Save("Formule.xml");        
        }

		public override string ToString ()
		{
			string ch = "Formule: "+ NomFormule + " \n " + "Temps de préparation: " + TempsDePreparation + " min\n " + " Estimation du temps de présence du client : " + EstimationTempsPresence + " min";
			return ch;
		}
    }
}
 
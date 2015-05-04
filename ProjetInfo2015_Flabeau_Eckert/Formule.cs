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
                  
        }
		public void EnregistrerFormule(XmlDocument xmlDoc, XmlNode rootNode)// Enregistre dans le fichier XML l'objet
		{

			xmlDoc.AppendChild(rootNode);

			XmlNode userNode = xmlDoc.CreateElement("Formule");
			rootNode.AppendChild(userNode);

			XmlAttribute attribute = xmlDoc.CreateAttribute("NomFormule");
			attribute.Value = this.NomFormule;
			userNode.Attributes.Append(attribute);
			rootNode.AppendChild(userNode);

			attribute = xmlDoc.CreateAttribute("TempsDePreparation");

			attribute.Value = this.TempsDePreparation.ToString();
			userNode.Attributes.Append(attribute);

			attribute = xmlDoc.CreateAttribute("EstimationTempsPresence");
			attribute.Value = this.EstimationTempsPresence.ToString();
			userNode.Attributes.Append(attribute);

			rootNode.AppendChild(userNode);

		}
		public override string ToString ()
		{
			string ch = "Formule: "+ NomFormule + " \n " + "Temps de préparation: " + TempsDePreparation + " min\n " + " Estimation du temps de présence du client : " + EstimationTempsPresence + " min";
			return ch;
		}
    }
}
 
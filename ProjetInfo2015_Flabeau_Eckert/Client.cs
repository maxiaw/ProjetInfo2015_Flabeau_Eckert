﻿using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Xml;

namespace ProjetInfo2015_Flabeau_Eckert
{
    [Serializable]
    public class Client
    {
        public string Nom { get; set; }
        public string NumeroTelephone { get; set; }

        public Client()
        {

        }

        public Client(string nom, string num)
        {
            Nom = nom;
            NumeroTelephone = num;
        }

		public void EnregistrerClient(XmlDocument xmlDoc, XmlNode rootNode)// Enregistre dans le fichier XML l'objet
        {

			xmlDoc.AppendChild(rootNode);

			XmlNode userNode = xmlDoc.CreateElement("Client");
			rootNode.AppendChild(userNode);

			XmlAttribute attribute = xmlDoc.CreateAttribute("Nom");
			attribute.Value = this.Nom;
			userNode.Attributes.Append(attribute);
			rootNode.AppendChild(userNode);

			attribute = xmlDoc.CreateAttribute("Telephone");
			attribute.Value = this.NumeroTelephone;
			userNode.Attributes.Append(attribute);
	
			rootNode.AppendChild(userNode);

        }

        public static Client ChargerClient()// Lit l'objet dans le fichier XML
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Client));
            StreamReader lecteur = new StreamReader("Client.xml");
            Client monClient = (Client)deserializer.Deserialize(lecteur);
            lecteur.Close();

            return monClient;
        }



    }
}


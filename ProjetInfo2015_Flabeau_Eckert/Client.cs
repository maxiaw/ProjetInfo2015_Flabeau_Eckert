using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

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

        public void EnregistrerClient()// Enregistre dans le fichier XML l'objet
        {

            XmlSerializer serializer = new XmlSerializer(typeof(Client));
            StreamWriter ecriture = new StreamWriter("Client.xml");
            serializer.Serialize(ecriture, this);
            ecriture.Close();
        }

        public static Client ChargerClient()// Lit l'objet dans le fichier XML
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Client));
            StreamReader lecteur = new StreamReader("Client.xml");
            Client monClient = (Client)deserializer.Deserialize(lecteur);
            lecteur.Close();

            return monClient;
        }


        public static void EnregistrerListeDeClient(List<Client> maListe)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            StreamWriter ecriture = new StreamWriter("ListeDeClient.xml");
            serializer.Serialize(ecriture, maListe);
            ecriture.Close();
        }

        public static List<Client> ChargerListeDeClient()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Client>));
            StreamReader lecteur = new StreamReader("ListeDeClient.xml");
            List<Client> maListe = (List<Client>)deserializer.Deserialize(lecteur);
            lecteur.Close();
            return maListe;
        }

    }
}


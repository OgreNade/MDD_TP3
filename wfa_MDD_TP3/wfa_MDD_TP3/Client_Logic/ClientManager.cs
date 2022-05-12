using System;
using System.Collections.Generic;

namespace wfa_MDD_TP3.Client_Logic
{
    public class ClientManager
    {
        public List<Client> clients;
        public int NouveauId { get; private set; }
        public ClientManager()
        {
            clients = new List<Client>();

            clients.Add(new Client(1, "D9553-300493-99", "Dumas", "Rapphael", "27/04/1993", "Homme", "418-228-7456", "418-222-8882", "RaphLeChef@hotmail.com", "Actif", "27/05/2021", "Roger"));
            clients.Add(new Client(2, "G8563-352390-50", "Girard", "Jean", "26/06/1990", "Homme", "418-228-5677", "418-221-6682", "GGirard773@outlook.com", "Actif", "22/07/2020", "Roger"));
            clients.Add(new Client(3, "H5553-458585-11", "Hook", "Martine", "11/01/1985", "Femme", "418-685-8874", "418-957-5699", "HookMart8@gmail.com", "Actif", "28/03/2022", "Roger"));
            clients.Add(new Client(4, "K1239-315495-85", "Keller", "Jino", "15/10/1995", "Homme", "418-774-5577", "418-974-7682", "KellerJino11@outlook.com", "Inactif", "20/09/2020", "Roger"));
            clients.Add(new Client(5, "P9473-300488-99", "Pascal", "Élodie", "12/06/1988", "Femme", "418-227-1177", "418-226-8266", "EloPascal@outlook.com", "Actif", "17/11/2020", "Roger"));
            clients.Add(new Client(6, "M9598-790475-14", "Martin", "Jacques", "22/08/1975", "Homme", "514-388-1119", "418-226-1017", "MartinJacques_entraineur@outlook.com", "Actif", "14/12/2021", "Roger"));
            clients.Add(new Client(7, "M9553-770470-19", "Macabbé", "Chantal", "21/06/1970", "Femme", "418-227-9996", "418-221-8163", "PasLaVraiCM@outlook.com", "Actif", "01/04/2022", "Roger"));
            clients.Add(new Client(8, "B9553-300469-95", "Bergevin", "Marc", "05/11/1969", "Homme", "418-228-1116", "418-974-6682", "BergMarc69@outlook.com", "Inactif", "16/07/2021", "Roger"));
            NouveauId = clients.Count + 1;
        }
        public Client GetClientParId(int IdClient)
        {
            foreach (var client in clients)
            {
                if (client.IdClient == IdClient)
                {
                    return client;
                }
            }
            throw new Exception("Aucun client trouver");
        }

        public void AjouterClient(Client nouveauClient)
        {
            clients.Add(nouveauClient);
            NouveauId++;
        }
    }
}

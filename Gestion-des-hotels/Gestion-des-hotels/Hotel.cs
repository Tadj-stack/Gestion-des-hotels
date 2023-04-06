namespace Gestion_des_hotels
{
    internal class Hotel
    {

        // le Nom de l hotel et la liste des client de l'hotel 
        public string NomDeHotel { get; set; }
        public List<Client> Clients { get; set; }
        //un contructeur qui intialise le nom de l'hotel et la liste des client 
        public Hotel(string nomDeHotel, List<Client> clients)
        {
            NomDeHotel = nomDeHotel;
            Clients = clients;
        }
        //La redefinition de la methode toString
        public override string ToString()
        {
            return $"Le Nom de l'Hotel :{NomDeHotel}\n";
        }


        //Methode pour ajouter un client a la liste des client de l'hotel 
        public void AjouterClient(Client client)
        {
            foreach (Client clnt1 in Clients)
            {

                //une condition pour verifier si le client se trouve deja dans la liste des clients 
                if (!clnt1.Equals(client))
                {
                    Clients.Add(client);
                }
                return;
            }
        }
        //Methode permet de supprimer un client a la liste des client de l'hotel
        public void SuppurimerClient(Client client)
        {
            foreach (Client clnt1 in Clients)
            {

                //une condition pour verifier si le client se trouve deja dans la liste des clients 
                if (!clnt1.Equals(client))
                {
                    Clients.Remove(client);
                }
                return;
            }





        }
    }
}
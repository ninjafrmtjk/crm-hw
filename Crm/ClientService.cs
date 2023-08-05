using Crm;

public sealed class ClientService
{

    private List<Client> clientList;
    public ClientService()
    {
        clientList = new List<Client>();
    }
    public Client CreateClient(ClientInfo clientInfo)
    {
        Client newClient = new Client();
        clientList.Add(newClient);
        return newClient;
    }

    public Client GetClient(string name, string surname)
    {
        return clientList.FirstOrDefault(client => client.FirstName == name && client.LastName == surname);
    }
}
using Crm;

Console.Write("Choose operation: 1 - Create client, 2 - Create Order: ");
short x = short.Parse(Console.ReadLine());

ClientService clientService = new();
OrderService orderService = new();

switch(x)
{
    case 1:
        CreateClient();
        break;
    case 2:
        CreateOrder();
        break;
    default:
        Console.WriteLine("The Input Is NOT VALID, Please Try Again");
        break;
}


void CreateClient()
{
    Console.Write("Type Your First Name: ");
    string firstName = Console.ReadLine();
    Console.Write("Type Your Last Name: ");
    string lastName = Console.ReadLine();
    Console.Write("Type Your Middle Name: ");
    string middleName = Console.ReadLine();
    Console.Write("Type Your Age: ");
    short age = short.Parse(Console.ReadLine());
    Console.Write("Type Your Passport Number: ");
    string passportNumber = Console.ReadLine();
    Console.Write("Type Your Gender: ");
    string gender = Console.ReadLine();

    Client newClient = clientService.CreateClient(new ClientInfo() {
        FirstName = firstName,
        LastName = lastName,
        MiddleName = middleName,
        Age = age,
        PassportNumber = passportNumber,
        Gender = gender
    });

    Console.WriteLine("Name: {0} {1} {2}", firstName, middleName, lastName);
    Console.WriteLine("Age: {0}", age);
    Console.WriteLine("Passport Number: {0}", passportNumber);
    Console.WriteLine("Gender: {0}", gender);
}

void CreateOrder()
{
    string name = Console.ReadLine();
    string color = Console.ReadLine();
    int id = int.Parse(Console.ReadLine());
    short price = short.Parse(Console.ReadLine());
    string description = Console.ReadLine();

    Order newOrder = orderService.CreateOrder(new OrderInfo() {
        Name = name,
        Color = color,
        Id = id,
        Price = price,
        Description = description
    });

    Console.WriteLine("Name: {0}", name);
    Console.WriteLine("Color: {0}", color);
    Console.WriteLine("ID: {0}", id);
    Console.WriteLine("Price: {0}", price);
    Console.WriteLine("Description: {0}", description);
}
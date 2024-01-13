using System.Text;
using DataAccess;
using Generation;

Random random = new(DateTime.Now.Millisecond * 1000 + DateTime.Now.Microsecond);

//ClientGen
NormalDist nameLenghtDist = new(6, 1, 4);
int numberOfClients = 10;

IEnumerable<Client> clients = new object?[numberOfClients]
    .Select(n => new Client()
    {
        Name = StringGenerator.Generate(nameLenghtDist),
        Surname = StringGenerator.Generate(nameLenghtDist)
    }).ToList();

//AutoGen
int numberOfAutos = 10;

IEnumerable<Auto> autos = clients
    .Take(numberOfAutos)
    .Select(
        client => new Auto()
        {
            VIM = StringGenerator.Generate(17, charset: Auto.VIMCharset),
            OwnerId = client.Id
        }).ToList();

if (numberOfAutos > numberOfClients)
    autos = autos.Concat(
        new object?[numberOfAutos - numberOfClients]
        .Select(n => new Auto
        {
            VIM = StringGenerator.Generate(17, charset: Auto.VIMCharset),
            OwnerId = clients.ElementAt(random.Next(clients.Count())).Id
        })
    ).ToList();

//Service gen
int numberOfServices = 10;

System.Console.WriteLine();
System.Console.WriteLine("Clients");
foreach (var c in clients)
    System.Console.WriteLine($"{c.Id} {c.Name} {c.Surname}");

System.Console.WriteLine();
System.Console.WriteLine("Autos");
foreach (var a in autos)
    System.Console.WriteLine($"{a.VIM} {a.OwnerId}");
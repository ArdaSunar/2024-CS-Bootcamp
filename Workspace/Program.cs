using Business.Concrete;

static void Greeting(string name="noname")
{
    Console.WriteLine("Merhaba " + name);

}

Greeting();

List<string> cities1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
cities1.Add("Adana");

foreach (var city in cities1)
{
    Console.WriteLine(city);
}


PttManager pttManager = new PttManager()
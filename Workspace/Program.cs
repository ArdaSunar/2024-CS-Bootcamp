 using Business.Concrete;
using Entities.Concrete;


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


PttManager pttManager = new PttManager();

Person person1 = new Person();
PersonManager personManager = new PersonManager();

person1.FirstName = "Arda";
person1.LastName = "Sunar";
person1.NationalIdentity = 456325346;

personManager.CheckPerson(person1);




using Business.Concrete;
using Entities.Concrete;


static void Greeting(string name="noname")
{
    Console.WriteLine("Merhaba " + name);

}

Greeting();

//Generic listing
List<string> cities1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
cities1.Add("Adana");

foreach (var city in cities1)
{
    Console.WriteLine(city);
}

Person person1 = new Person();
PttManager pttManager = new PttManager(new PersonManager());






person1.FirstName = "Arda";
person1.LastName = "Sunar";
person1.NationalIdentity = 123;
person1.DateOfBirthYear = 1998;

pttManager.GiveMask(person1);





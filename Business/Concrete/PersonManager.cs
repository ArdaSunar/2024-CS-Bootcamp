using System;
using Entities.Concrete;
using Business.Abstract;

namespace Business.Concrete;

//Çıplak class kalmasın -Engin Demiroğ

public class PersonManager : IApplicantService
{
	public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {
        return null;
    }

    public bool CheckPerson(Person person)
    {
        
        return true;
    }

}


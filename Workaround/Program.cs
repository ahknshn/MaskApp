using Business.Concrete;
using Entities.Concrete;
using System;
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.FirstName = "AHMET";
        person1.LastName = "HAKAN";
        person1.DateOfBirthYear = 2024;
        person1.NationalIdentity = 111;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }

}